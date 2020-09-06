// Parámetros para la tabla SUCURSAL 
using System;
using System.Collections.Generic;

namespace EXIWARE.Params{
    public class ManyFuncs{
        // Convertir string a long.
        public static long str2long( string str ){
            try{
                if( str==null ){
                    return -1;
                }
                return long.Parse(str);
            }catch( FormatException  ex ){
                Console.WriteLine( "------------------------------------------" );
                Console.WriteLine( "Error FUNCTION (DBFuncs.str2long):" + ex );
                Console.WriteLine( "------------------------------------------" );
                return -1;
            }
        }
        //
    }   
    //
    //
    //
    public class AdminLoginInput
    {
        public string Id { get; set; }
        public string Pss { get; set; }
    }  
    //
    //
    //
    public class AdminInsertNew
    {
        public string Id_Card { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string IsSuperAdmin { get; set; }
    }  
    //
    //
    //
    public class AdminModify
    {
        public string Id_Card { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string State { get; set; }
        public string IsSuperAdmin { get; set; }
    }
    //
    //
    //
    public class AdminViews{
        public const string sname = "ExiWareSes";
        public static AdministradoresParams AdparA = null;
        public static List<AdministradoresParams> AdparAllA = null;
        public AdministradoresParams Adpar { get; set; }
        public List<AdministradoresParams> AdparAll { get; set; }
        public bool SesInit { get; set; }
    }

}
