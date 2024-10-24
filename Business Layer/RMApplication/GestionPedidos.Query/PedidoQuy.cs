using GestionPedidos.Interfaces;
using GestionPedidos.Query.Interfaces;
using RMMensajeria.GestionPedidos;
using Utilidades;

namespace GestionPedidos.Query;

public class PedidoQuy : IPedidoQuy
{
    private readonly IGestorId _gestorId;
    public PedidoQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public PedidoMS DevuelvePedido(PedidoME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IPedidoActor>().ObtenerPedidoPorId(mensajeEntrada.PedidoID);
        return new PedidoMS
        {
            PedidoID = salida.PedidoID,
            ClienteID = salida.ClienteID,
            FechaPedido = salida.FechaPedido,
            EstadoPedido = salida.EstadoPedido,
            Total = salida.Total,
            MetodoPago = salida.MetodoPago,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };
    }

    public PedidoMSLista DevuelveTodosPedidoes(PedidoME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IPedidoActor>().ObtenerListaPedido();
        var listaMS =
            lista.Transformar(pedido =>
            new PedidoMS(pedido.PedidoID,
                        pedido.ClienteID,
                        pedido.FechaPedido,
                        pedido.EstadoPedido,
                        pedido.Total,
                        pedido.MetodoPago,
                        pedido.FechaCreacion,
                        pedido.FechaActualizacion));
        return new PedidoMSLista(listaMS.ToArray());

    }
}
