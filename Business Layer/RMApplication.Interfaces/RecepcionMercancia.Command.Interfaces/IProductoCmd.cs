using RMMensajeria;

namespace RecepcionMercancia.Command.Interfaces;

public interface IProductoCmd
{
    ProductoMS NuevoProducto(ProductoME mensajeEntrada);
    ProductoMS ActualizaProducto(ProductoME mensajeEntrada);
}
