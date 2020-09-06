// Parámetros para la tabla SUCURSAL 
using System;
public class EmpleadosParams
{
    // Default Id.
    public long Id { get; set; }
    public long IdCard { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public long Phone { get; set; }
    public string Password { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public EmpleadosParams()
    {          
        this.CreatedDate  = DateTime.UtcNow;
        this.ModifiedDate = DateTime.UtcNow;
    }
}