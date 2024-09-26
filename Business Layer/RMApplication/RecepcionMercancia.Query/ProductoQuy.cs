using RecepcionMercancia;
using RMMensajeria;
using Servicios.Interfaces;
using Utilidades;


namespace Servicios.RecepcionMercancia;

public class ProductoQuy : IProductoQuy
{
    private readonly IGestorId _gestorId;
    public ProductoQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public ProductoMS DevuelveProducto(ProductoME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IProductoActor>().ObtenerProductoPorId(mensajeEntrada.ProductoID);
        return new ProductoMS
        {
            ProductoID = salida.ProductoID,
            CodigoProducto = salida.CodigoProducto,
            NombreProducto = salida.NombreProducto,
            Descripcion = salida.Descripcion,
            UnidadMedida = salida.UnidadMedida,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };
    }
}
