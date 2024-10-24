using GestionPedidos.Command.Interfaces;
using GestionPedidos.Entidad;
using GestionPedidos.Interfaces;
using RMMensajeria.GestionPedidos;
using Utilidades;

namespace GestionPedidos.Command;

public class ClienteCmd : IClienteCmd
{
    private readonly IGestorId _gestorId;
    public ClienteCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public ClienteMS NuevoCliente(ClienteME mensajeEntrada)
    {

        var nuevoCliente =
            new Cliente(
                mensajeEntrada.ClienteID,
                mensajeEntrada.Nombre,
                mensajeEntrada.CorreoElectronico,
                mensajeEntrada.Telefono,
                mensajeEntrada.Direccion,
                mensajeEntrada.FechaCreacion,
                mensajeEntrada.FechaActualizacion);

        _gestorId.Resuelve<IClienteActor>().ProcesaInsertar(nuevoCliente);

        return new ClienteMS
               (nuevoCliente.ClienteID,
                nuevoCliente.Nombre,
                nuevoCliente.CorreoElectronico,
                nuevoCliente.Telefono,
                nuevoCliente.Direccion,
                nuevoCliente.FechaCreacion,
                nuevoCliente.FechaActualizacion);
    }

    public ClienteMS EliminarCliente(ClienteME mensajeEntrada)
    {
        var clienteActor = _gestorId.Resuelve<IClienteActor>();
        var cliente = _gestorId.Resuelve<IClienteActor>().ObtenerClientePorId(mensajeEntrada.ClienteID);

        clienteActor.ProcesaEliminar(cliente);

        return new ClienteMS();
    }
}
