
using System.Linq;
using EXIWARE.Params;
using Microsoft.AspNetCore.Http;

namespace EXIWARE.Controllers
{
    public class FAdmin{
        Models.DbContextEXIWARE db;
        public FAdmin( Models.DbContextEXIWARE dbi ){
            db = dbi;
        }
        //
        public AdministradoresParams GetAdmin( long IdCard ){
            return db.ADMINISTRADORES.Where( s => s.Id_card == (long)IdCard ).FirstOrDefault();
        }
        //
        public bool IsAdmin( long IdCard ){
            return GetAdmin(IdCard)!=null;
        }
        //
        //
        //
        public bool InitSes( long IdCard, string Pss, HttpContext HttpC ){
            AdministradoresParams adpar = db.ADMINISTRADORES.Where( s => s.Id_card == (long)IdCard ).FirstOrDefault();
            if( adpar==null ){
                return false;
            }
            if( !adpar.Password.Equals(Pss) ){
                return false;
            }
            string sval = adpar.Id_card + "";
            adpar.SesionValue = sval;
            adpar.SesionState = true;
            db.ADMINISTRADORES.Where(
                    s => s.Id_card == (long)IdCard
            ).Append(adpar);
            db.SaveChanges();
            AdminViews.AdparA = adpar;
            AdminViews.AdparAllA = db.ADMINISTRADORES.ToList();
            string str2r = HttpC.Session.GetString( AdminViews.sname );
            if( str2r==null ){
                byte[] v_sval = System.Text.UTF8Encoding.UTF8.GetBytes(sval);
                HttpC.Session.Set( AdminViews.sname, v_sval );
            }
            return true;
        }
        //
        //
        // Finalizar Sesion de administrador.
        public bool EndSes( HttpContext HttpC ){
            string str2r = HttpC.Session.GetString( AdminViews.sname );
            if( str2r!=null ){
                HttpC.Session.Remove(AdminViews.sname);
            }
            return true;
        }
        //
        //
        
        //
        //
        // Obtener informacion de la sesion.
        public AdminViews GetSesInfo( HttpContext HttpC ){
            string str2r = HttpC.Session.GetString( AdminViews.sname );
            if( str2r!=null ){
                AdministradoresParams adpar = db.ADMINISTRADORES.Where( s => s.SesionValue == str2r ).FirstOrDefault();
                AdminViews adv = new AdminViews();
                adv.Adpar = AdminViews.AdparA;
                adv.AdparAll = AdminViews.AdparAllA;
                adv.SesInit = true;
                return adv;
            }
            return null;
        }
        //
    }

}