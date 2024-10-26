using GestionCompras.Command.Interfaces;
using GestionCompras.Entidad;
using GestionCompras.Interfaces;
using RMMensajeria.GestionCompras;
using Utilidades;

namespace GestionCompras.Command;

public class DetallesOrdenCompraCmd: IDetallesOrdenCompraCmd
{
    private readonly IGestorId _gestorId;
    public DetallesOrdenCompraCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public DetallesOrdenCompraMS NuevoDetallesOrdenCompra(DetallesOrdenCompraME mensajeEntrada)
    {
        var nuevoDetallesOrdenCompra =
            new DetallesOrdenCompra(
                mensajeEntrada.DetalleOrdenCompraID,
                mensajeEntrada.OrdenCompraID,
                mensajeEntrada.ProductoID,
                mensajeEntrada.Cantidad,
                mensajeEntrada.PrecioUnitario,
                mensajeEntrada.Subtotal,
                mensajeEntrada.FechaCreacion,
                mensajeEntrada.FechaActualizacion);

        _gestorId.Resuelve<IDetallesOrdenCompraActor>().ProcesaInsertar(nuevoDetallesOrdenCompra);

        return new DetallesOrdenCompraMS
               (nuevoDetallesOrdenCompra.DetalleOrdenCompraID,
                nuevoDetallesOrdenCompra.OrdenCompraID,
                nuevoDetallesOrdenCompra.ProductoID,
                nuevoDetallesOrdenCompra.Cantidad,
                nuevoDetallesOrdenCompra.PrecioUnitario,
                nuevoDetallesOrdenCompra.Subtotal,
                nuevoDetallesOrdenCompra.FechaCreacion,
                nuevoDetallesOrdenCompra.FechaActualizacion);
    }
    public DetallesOrdenCompraMS EliminarDetallesOrdenCompra(DetallesOrdenCompraME mensajeEntrada)
    {
        var DetallesOrdenCompraActor = _gestorId.Resuelve<IDetallesOrdenCompraActor>();
        var DetallesOrdenCompra = _gestorId.Resuelve<IDetallesOrdenCompraActor>().ObtenerDetallesOrdenCompraPorId(mensajeEntrada.OrdenCompraID);

        DetallesOrdenCompraActor.ProcesaEliminar(DetallesOrdenCompra);

        return new DetallesOrdenCompraMS();
    }
}
