// Parámetros para la tabla SUCURSAL 
using System;
public class ClientesParams
{
    // Default Id.
    public long Id { get; set; }
    public long Id_card { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public bool State { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public ClientesParams()
    {          
        this.CreatedDate  = DateTime.UtcNow;
        this.ModifiedDate = DateTime.UtcNow;
    }
}