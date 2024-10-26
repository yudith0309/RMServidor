using GestionCompras.Command.Interfaces;
using GestionCompras.Entidad;
using GestionCompras.Interfaces;
using RMMensajeria.GestionCompras;
using Utilidades;

namespace GestionCompras.Command;

public class ItemDeOrdenDeCompraCmd: IItemDeOrdenDeCompraCmd
{
    private readonly IGestorId _gestorId;
    public ItemDeOrdenDeCompraCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public ItemDeOrdenDeCompraMS NuevoItemDeOrdenDeCompra(ItemDeOrdenDeCompraME mensajeEntrada)
    {
        var nuevoItemDeOrdenDeCompra =
            new ItemDeOrdenDeCompra(
                mensajeEntrada.ItemDeOrdenDeCompraID,
                mensajeEntrada.OrdenDeCompraID,
                mensajeEntrada.ProductoID,
                mensajeEntrada.CantidadOrdenada,
                mensajeEntrada.PrecioUnitario);
        
        _gestorId.Resuelve<IItemDeOrdenDeCompraActor>().ProcesaInsertar(nuevoItemDeOrdenDeCompra);

        return new ItemDeOrdenDeCompraMS
               (nuevoItemDeOrdenDeCompra.ItemDeOrdenDeCompraID,
                nuevoItemDeOrdenDeCompra.OrdenDeCompraID,
                nuevoItemDeOrdenDeCompra.ProductoID,
                nuevoItemDeOrdenDeCompra.CantidadOrdenada,
                nuevoItemDeOrdenDeCompra.PrecioUnitario);
    }
    public ItemDeOrdenDeCompraMS EliminarItemDeOrdenDeCompra(ItemDeOrdenDeCompraME mensajeEntrada)
    {
        var ItemDeOrdenDeCompraActor = _gestorId.Resuelve<IItemDeOrdenDeCompraActor>();
        var ItemDeOrdenDeCompra = _gestorId.Resuelve<IItemDeOrdenDeCompraActor>().ObtenerItemDeOrdenDeCompraPorId(mensajeEntrada.ItemDeOrdenDeCompraID);

        ItemDeOrdenDeCompraActor.ProcesaEliminar(ItemDeOrdenDeCompra);

        return new ItemDeOrdenDeCompraMS();
    }
}
