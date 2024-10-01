namespace RMMensajeria;

public class ProductoMS
{
    public Guid ProductoID { get; set; }
    public string? CodigoProducto { get; set; }
    public string? NombreProducto { get; set; }
    public string? Descripcion { get; set; }
    public string? UnidadMedida { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaActualizacion { get; set; }

    public ProductoMS() { }

    public ProductoMS(Guid productoID, string codigoProducto, string nombreProducto, string descripcion, string unidadMedida, DateTime fechaCreacion, DateTime fechaActualizacion)
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

public class ProductosMSLista
{
    public ProductosMSLista() { }

    public ProductosMSLista(ProductoMS[] productoMS)
    {
        ProductoMS = productoMS;
    }
    public ProductoMS[] ProductoMS { get; set; }
}
