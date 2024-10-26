using RMMensajeria.GestionCompras;

namespace GestionCompras.Query.Interfaces;

public interface IDetallesOrdenCompraQuy
{
    DetallesOrdenCompraMS DevuelveDetallesOrdenCompra(DetallesOrdenCompraME mensajeEntrada);
    DetallesOrdenCompraMSLista DevuelveTodosDetallesOrdenCompraes(DetallesOrdenCompraME mensajeEntrada);
}
