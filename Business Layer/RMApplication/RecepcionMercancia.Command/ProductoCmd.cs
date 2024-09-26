using RecepcionMercancia;
using RecepcionMercancia.Entidad;
using RMMensajeria;
using ServiciosCmd.Interfaces;
using Utilidades;

namespace Servicios;

public class ProductoCmd : IProductoCmd
{
    private readonly IGestorId _gestorId;
    public ProductoCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public ProductoMS NuevoProducto(ProductoME mensajeEntrada)
    {
        var nuevoProducto =
            new Producto(
                mensajeEntrada.ProductoID,
                mensajeEntrada.CodigoProducto,
                mensajeEntrada.NombreProducto,
                mensajeEntrada.Descripcion,
                mensajeEntrada.UnidadMedida,
                mensajeEntrada.FechaCreacion,
                mensajeEntrada.FechaActualizacion);

        _gestorId.Resuelve<IProductoActor>().ProcesaInsertar(nuevoProducto);

        return new ProductoMS
               (nuevoProducto.ProductoID,
                nuevoProducto.CodigoProducto,
                nuevoProducto.NombreProducto,
                nuevoProducto.Descripcion,
                nuevoProducto.UnidadMedida,
                nuevoProducto.FechaCreacion,
                nuevoProducto.FechaActualizacion);
    }

    public ProductoMS ActualizaProducto(ProductoME mensajeEntrada)
    {
        var nuevoProducto =
            new Producto(
                mensajeEntrada.ProductoID,
                mensajeEntrada.CodigoProducto,
                mensajeEntrada.NombreProducto,
                mensajeEntrada.Descripcion,
                mensajeEntrada.UnidadMedida,
                mensajeEntrada.FechaCreacion,
                mensajeEntrada.FechaActualizacion);

        return new ProductoMS
               (nuevoProducto.ProductoID,
                nuevoProducto.CodigoProducto,
                nuevoProducto.NombreProducto,
                nuevoProducto.Descripcion,
                nuevoProducto.UnidadMedida,
                nuevoProducto.FechaCreacion,
                nuevoProducto.FechaActualizacion);
    }


}
