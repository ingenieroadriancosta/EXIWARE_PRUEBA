// Parámetros para la tabla SUCURSAL 
using System;
public class AdministradoresParams
{
    // Default Id.
    public long Id { get; set; }
    public long Id_card { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public long Phone { get; set; }
    public string Password { get; set; }
    public string SesionValue { get; set; }
    public bool SesionState { get; set; }
    public bool State { get; set; }
    public bool SuperAdmin { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public AdministradoresParams()
    {          
        this.CreatedDate  = DateTime.UtcNow;
        this.ModifiedDate = DateTime.UtcNow;
    }
    //
    //
    //
    //
    /*
    */
    //
    //
    //
    //
}