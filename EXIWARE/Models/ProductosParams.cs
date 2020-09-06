// Parámetros para la tabla SUCURSAL 
using System;
public class ProductosParams
{
    // Default Id.
    public long Id { get; set; }
    public string Name { get; set; }
    public long Stock { get; set; }
    public long Product_code { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public ProductosParams()
    {          
        this.CreatedDate  = DateTime.UtcNow;
        this.ModifiedDate = DateTime.UtcNow;
    }
}