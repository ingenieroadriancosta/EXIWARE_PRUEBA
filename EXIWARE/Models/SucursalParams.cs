// Parámetros para la tabla SUCURSAL 
using System;
public class SucursalParams
{
    // Default Id.
    public long Id { get; set; }
    public long IdSucursal { get; set; }
    public string Name { get; set; }
    public long Phone { get; set; }
    public string Address { get; set; }
    public string Password { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public SucursalParams()
    {          
        this.CreatedDate  = DateTime.UtcNow;
        this.ModifiedDate = DateTime.UtcNow;
    }
}