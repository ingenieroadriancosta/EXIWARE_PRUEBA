using Microsoft.AspNetCore.Mvc;
using EXIWARE.Params;
using Microsoft.AspNetCore.Http;
using System;

namespace EXIWARE.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("/api")]
    public class APIController : Controller
    {
        /*
            La funcion (LoginAdmin) administra el sitio,
            los administradores son los unico capaces de 
            agregar otros administradores y empleados.
            Los administradores pueden agregar otros 
            administradores de otras sucursales, sin embargo,
            no pueden agregar empleados de otras sucursales.
        */
        [HttpPost("[action]"), FormatFilter]
        public IActionResult LoginAdmin( [FromBody]AdminLoginInput Vlogin )
        {
            if( !FAd.IsAdmin(123456789) ){
                AdministradoresParams adp = new AdministradoresParams();
                adp.Id_card = 123456789;
                adp.Name = "Adrian";
                adp.LastName = "Costa";
                adp.Phone = 3008053163;
                adp.Password = "admin";
                adp.SesionValue = "123";
                adp.State = true;
                adp.SuperAdmin = true;
                db.ADMINISTRADORES.Add(adp);
                db.SaveChanges();
            }
            if( Vlogin.Id==null || Vlogin.Pss==null ){
                return Json("");
            }
            long IdCard = ManyFuncs.str2long(Vlogin.Id);
            if( IdCard<0 ){
                return Json("");
            }
            if( !FAd.InitSes(IdCard, Vlogin.Pss, HttpContext) ){
                return Json("");
            }
            return Json( "Ok: " + Vlogin.Id + ":" + Vlogin.Pss );
        }
        //
        //
        //
        /*
            INgresar nuevo administrador.
        */
        [HttpGet("[action]"), FormatFilter]
        public IActionResult  GetAdmin()
        {
            if( FAd.GetSesInfo( HttpContext )==null ){
                return Json( "Fail: SESION FINALIZADA" );
            }
            long id_c = ManyFuncs.str2long( Request.Query["id"] );
            if( id_c<0 ){
                return Json( "Fail: if id_c 0 " + Request.Query["id"] );
            }
            if( !FAd.IsAdmin( id_c ) ){
                return Json( "Fail: Administrador no encontrado." );
            }
            return Json( FAd.GetAdmin(id_c) );
        }
        //
        //
        //
        /*
            INgresar nuevo administrador.
        */
        [HttpPut("[action]"), FormatFilter]
        public IActionResult ActualizarAdmin( [FromBody]AdminModify VModify )
        {
            return Json( "Fail in" );
        }
        //
        //
        //
        /*
            INgresar nuevo administrador.
        */
        [HttpPost("[action]"), FormatFilter]
        public IActionResult InsertAdmin( [FromBody]AdminInsertNew Vinsert )
        {
            AdministradoresParams adp = new AdministradoresParams();
            if( Vinsert==null ){
                return Json( "Fail" );
            }
            adp.Id_card = ManyFuncs.str2long(Vinsert.Id_Card);
            if( adp.Id_card<0 ){
                return Json( "Fail  IDCARD not found" );
            }
            if( FAd.IsAdmin(adp.Id_card) ){
                return Json( "Fail: ADMINISTRADOR EXISTENTE" );
            }
            if( FAd.GetSesInfo( HttpContext )==null ){
                return Json( "Fail: SESION FINALIZADA" );
            }
            adp.Name = Vinsert.Name;
            adp.LastName = Vinsert.LastName;
            adp.Phone = ManyFuncs.str2long(Vinsert.Phone);
            adp.Password = Vinsert.Password;
            adp.SesionValue = HttpContext.Session.GetString( AdminViews.sname );
            adp.State = true;
            adp.SuperAdmin = bool.Parse( Vinsert.IsSuperAdmin+"" ) ||
                                Vinsert.IsSuperAdmin.Equals("true");
            db.ADMINISTRADORES.Add(adp);
            db.SaveChanges();
            return Json( "Ok" );
        }
        //
        //
        //
        /*
            Finalizar sesion.
        */
        [HttpGet("[action]")]
        public IActionResult LogOutAdmin()
        {
            FAd.EndSes( HttpContext );
            return Json("Ok");
        }
        //
        //
        //
        /*
            Obtener datos de la sesion.
        */
        [HttpGet("[action]")]
        public IActionResult GetSesion()
        {
            return Json( FAd.GetSesInfo(HttpContext) );
        }
        //
        //
        //
        /*
        */
        [HttpGet("[action]")]
        public IActionResult Index()
        {
            return Json("Index: ");
        }
        //
        //
        //
        private Models.DbContextEXIWARE db;
        private FAdmin FAd;
        public APIController(Models.DbContextEXIWARE context) {
            this.db = context;
            FAd = new FAdmin( this.db );
        }
    }
}