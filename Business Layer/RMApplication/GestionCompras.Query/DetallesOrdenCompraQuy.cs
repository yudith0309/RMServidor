using GestionCompras.Interfaces;
using GestionCompras.Query.Interfaces;
using RMMensajeria.GestionCompras;
using Utilidades;

namespace GestionCompras.Query;

public class DetallesOrdenCompraQuy: IDetallesOrdenCompraQuy
{
    private readonly IGestorId _gestorId;
    public DetallesOrdenCompraQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public DetallesOrdenCompraMS DevuelveDetallesOrdenCompra(DetallesOrdenCompraME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IDetallesOrdenCompraActor>().ObtenerDetallesOrdenCompraPorId(mensajeEntrada.OrdenCompraID);
        return new DetallesOrdenCompraMS
        {
            DetalleOrdenCompraID = salida.OrdenCompraID,
            OrdenCompraID = salida.OrdenCompraID,
            ProductoID = salida.ProductoID,
            Cantidad = salida.Cantidad,
            PrecioUnitario = salida.PrecioUnitario,
            Subtotal = salida.Subtotal,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };
    }
    public DetallesOrdenCompraMSLista DevuelveTodosDetallesOrdenCompraes(DetallesOrdenCompraME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IDetallesOrdenCompraActor>().ObtenerListaDetallesOrdenCompra();
        var listaMS =
            lista.Transformar(detallesOrdenCompra =>
            new DetallesOrdenCompraMS(detallesOrdenCompra.OrdenCompraID,
                                      detallesOrdenCompra.OrdenCompraID,
                                      detallesOrdenCompra.ProductoID,
                                      detallesOrdenCompra.Cantidad,
                                      detallesOrdenCompra.PrecioUnitario,
                                      detallesOrdenCompra.Subtotal,
                                      detallesOrdenCompra.FechaCreacion,
                                      detallesOrdenCompra.FechaActualizacion));
        return new DetallesOrdenCompraMSLista(listaMS.ToArray());
    }
}
