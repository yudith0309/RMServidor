using GestionPedidos.Interfaces;
using GestionPedidos.Query.Interfaces;
using RMMensajeria.GestionPedidos;
using Utilidades;

namespace GestionPedidos.Query;

public class DetallesPedidoQuy: IDetallesPedidoQuy
{
    private readonly IGestorId _gestorId;
    public DetallesPedidoQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public DetallesPedidoMS DevuelveDetallesPedido(DetallesPedidoME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IDetallesPedidoActor>().ObtenerDetallesPedidoPorId(mensajeEntrada.DetalleID);
        return new DetallesPedidoMS
        {
            DetalleID = salida.DetalleID,
            PedidoID = salida.PedidoID,
            ProductoID = salida.ProductoID,
            Cantidad = salida.Cantidad,
            PrecioUnitario = salida.PrecioUnitario,
            Subtotal = salida.Subtotal,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };
    }

    public DetallesPedidoMSLista DevuelveTodosDetallesPedidoes(DetallesPedidoME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IDetallesPedidoActor>().ObtenerListaDetallesPedido();
        var listaMS =
            lista.Transformar(detallesPedido =>
            new DetallesPedidoMS(detallesPedido.DetalleID,
                                 detallesPedido.PedidoID,
                                 detallesPedido.ProductoID,
                                 detallesPedido.Cantidad,
                                 detallesPedido.PrecioUnitario,
                                 detallesPedido.Subtotal,
                                 detallesPedido.FechaCreacion,
                                 detallesPedido.FechaActualizacion));
        return new DetallesPedidoMSLista(listaMS.ToArray());

    }
}
