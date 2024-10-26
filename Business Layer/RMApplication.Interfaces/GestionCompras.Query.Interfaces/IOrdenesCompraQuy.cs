using RMMensajeria.GestionCompras;

namespace GestionCompras.Query.Interfaces;

public interface IOrdenesCompraQuy
{
    OrdenesCompraMS DevuelveOrdenesCompra(OrdenesCompraME mensajeEntrada);
    OrdenesCompraMSLista DevuelveTodosOrdenesCompraes(OrdenesCompraME mensajeEntrada);
}
