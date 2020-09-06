using Microsoft.AspNetCore.Mvc;
using EXIWARE.Params;
// using Params;
using Microsoft.AspNetCore.Http;
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
                


                AdministradoresParams adp2 = new AdministradoresParams();
                adp2.Id_card = 1234;
                adp2.Name = "EXIWARE";
                adp2.LastName = "CO";
                adp2.Phone = 5717044177;
                adp2.Password = "exiadmin";
                adp2.SesionValue = "123";
                adp2.State = true;
                adp2.SuperAdmin = true;
                db.ADMINISTRADORES.Add(adp2);
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
            Finalizar sesion.
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
            Finalizar sesion.
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