using RMMensajeria.GestionPedidos;

namespace GestionPedidos.Command.Interfaces;

public interface IClienteCmd
{
    ClienteMS NuevoCliente(ClienteME mensajeEntrada);
    ClienteMS EliminarCliente(ClienteME mensajeEntrada);
}
