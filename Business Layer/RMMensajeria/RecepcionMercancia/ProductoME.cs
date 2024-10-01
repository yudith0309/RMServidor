namespace RMMensajeria;

public class ProductoME
{
    public Guid ProductoID { get; set; }  
    public string? CodigoProducto { get; set; }  
    public string? NombreProducto { get; set; }  
    public string? Descripcion { get; set; }  
    public string? UnidadMedida { get; set; }  
    public DateTime FechaCreacion { get; set; } 
    public DateTime FechaActualizacion { get; set; }

    public ProductoME()   { }

    public ProductoME(Guid productoID, string codigoProducto, string nombreProducto, string descripcion, string unidadMedida, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        ProductoID = productoID;
        CodigoProducto = codigoProducto;
        NombreProducto = nombreProducto;
        Descripcion = descripcion;
        UnidadMedida = unidadMedida;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
}
