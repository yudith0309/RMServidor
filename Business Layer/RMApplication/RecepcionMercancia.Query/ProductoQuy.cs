using RecepcionMercancia.Interfaces;
using RecepcionMercancia.Query.Interfaces;
using RMMensajeria;
using Utilidades;

namespace RecepcionMercancia.Query;

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

    public ProductosMSLista DevuelveTodosProductos(ProductoME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IProductoActor>().ObtenerListaProducto();
        var listaMS =
            lista.Transformar(producto =>
            new ProductoMS(producto.ProductoID,
                           producto.CodigoProducto,
                           producto.NombreProducto,
                           producto.Descripcion,
                           producto.UnidadMedida,
                           producto.FechaCreacion,
                           producto.FechaActualizacion));

        return new ProductosMSLista(listaMS.ToArray());

    }
}
