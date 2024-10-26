using RMMensajeria.GestionCompras;

namespace GestionCompras.Query.Interfaces;

public interface IItemDeOrdenDeCompraQuy
{
    ItemDeOrdenDeCompraMS DevuelveItemDeOrdenDeCompra(ItemDeOrdenDeCompraME mensajeEntrada);
    ItemDeOrdenDeCompraMSLista DevuelveTodosItemDeOrdenDeCompraes(ItemDeOrdenDeCompraME mensajeEntrada);
}
