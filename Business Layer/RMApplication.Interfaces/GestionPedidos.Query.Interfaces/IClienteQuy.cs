using RMMensajeria.GestionPedidos;

namespace GestionPedidos.Query.Interfaces;

public interface IClienteQuy
{
    ClienteMS DevuelveCliente(ClienteME mensajeEntrada);
    ClienteMSLista DevuelveTodosClientees(ClienteME mensajeEntrada);
}
