using RMMensajeria.GestionCompras;

namespace GestionCompras.Command.Interfaces;

public interface IItemDeOrdenDeCompraCmd
{
    ItemDeOrdenDeCompraMS NuevoItemDeOrdenDeCompra(ItemDeOrdenDeCompraME mensajeEntrada);
    ItemDeOrdenDeCompraMS EliminarItemDeOrdenDeCompra(ItemDeOrdenDeCompraME mensajeEntrada);

}
