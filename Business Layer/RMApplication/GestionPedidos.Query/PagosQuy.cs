using GestionPedidos.Interfaces;
using GestionPedidos.Query.Interfaces;
using RMMensajeria.GestionPedidos;
using Utilidades;

namespace GestionPedidos.Query;

public class PagosQuy: IPagosQuy
{
    private readonly IGestorId _gestorId;
    public PagosQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public PagosMS DevuelvePagos(PagosME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IPagosActor>().ObtenerPagosPorId(mensajeEntrada.PagoID);
        return new PagosMS
        {
            PagoID = salida.PagoID,
            PedidoID = salida.PedidoID,
            Monto = salida.Monto,
            FechaPago = salida.FechaPago,
            MetodoPago = salida.MetodoPago,
            EstadoPago = salida.EstadoPago,
            FechaCreacion = salida.FechaPago,
            FechaActualizacion = salida.FechaActualizacion
        };
    }

    public PagosMSLista DevuelveTodosPagoses(PagosME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IPagosActor>().ObtenerListaPagos();
        var listaMS =
            lista.Transformar(pagos =>
            new PagosMS(pagos.PagoID,
                        pagos.PedidoID,
                        pagos.Monto,
                        pagos.FechaPago,
                        pagos.MetodoPago,
                        pagos.EstadoPago,
                        pagos.FechaCreacion,
                        pagos.FechaActualizacion));
        return new PagosMSLista(listaMS.ToArray());

    }
}
