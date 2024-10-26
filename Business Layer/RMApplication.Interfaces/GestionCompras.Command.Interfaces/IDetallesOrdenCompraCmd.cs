using RMMensajeria.GestionCompras;

namespace GestionCompras.Command.Interfaces;

public interface IDetallesOrdenCompraCmd
{
    DetallesOrdenCompraMS NuevoDetallesOrdenCompra(DetallesOrdenCompraME mensajeEntrada);
    DetallesOrdenCompraMS EliminarDetallesOrdenCompra(DetallesOrdenCompraME mensajeEntrada);
}
