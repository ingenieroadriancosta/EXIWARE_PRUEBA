// Parámetros para la tabla SUCURSAL 
using System;
public class PedidoDetalleParams
{
    // Default Id.
    public long Id { get; set; }
    public long IdSucursal { get; set; }
    public long IdCard_E { get; set; }
    public long IdCard_C { get; set; }
    public long IdDetalle { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public PedidoDetalleParams()
    {          
        this.CreatedDate  = DateTime.UtcNow;
        this.ModifiedDate = DateTime.UtcNow;
    }
}