using GestionPedidos.Interfaces;
using GestionPedidos.Query.Interfaces;
using RMMensajeria.GestionPedidos;
using Utilidades;

namespace GestionPedidos.Query;

public class ClienteQuy: IClienteQuy
{
    private readonly IGestorId _gestorId;
    public ClienteQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public ClienteMS DevuelveCliente(ClienteME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IClienteActor>().ObtenerClientePorId(mensajeEntrada.ClienteID);
        return new ClienteMS
        {
            ClienteID = salida.ClienteID,
            Nombre = salida.Nombre,
            CorreoElectronico = salida.CorreoElectronico,
            Telefono = salida.Telefono,
            Direccion = salida.Direccion,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };
    }

    public ClienteMSLista DevuelveTodosClientees(ClienteME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IClienteActor>().ObtenerListaCliente();
        var listaMS =
            lista.Transformar(cliente =>
            new ClienteMS(cliente.ClienteID,
                          cliente.Nombre,
                          cliente.CorreoElectronico,
                          cliente.Telefono,
                          cliente.Direccion,
                          cliente.FechaCreacion,
                          cliente.FechaActualizacion));
        return new ClienteMSLista(listaMS.ToArray());

    }
}
