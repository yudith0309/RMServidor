using GestionCompras.Interfaces;
using GestionCompras.Query.Interfaces;
using RMMensajeria.GestionCompras;
using Utilidades;

namespace GestionCompras.Query;

public class ItemDeOrdenDeCompraQuy: IItemDeOrdenDeCompraQuy
{
    private readonly IGestorId _gestorId;
    public ItemDeOrdenDeCompraQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public ItemDeOrdenDeCompraMS DevuelveItemDeOrdenDeCompra(ItemDeOrdenDeCompraME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IItemDeOrdenDeCompraActor>().ObtenerItemDeOrdenDeCompraPorId(mensajeEntrada.ItemDeOrdenDeCompraID);
        return new ItemDeOrdenDeCompraMS
        {
            ItemDeOrdenDeCompraID = salida.ItemDeOrdenDeCompraID,
            OrdenDeCompraID = salida.OrdenDeCompraID,
            ProductoID = salida.ProductoID,
            CantidadOrdenada = salida.CantidadOrdenada,
            PrecioUnitario = salida.PrecioUnitario
        };
    }
    public ItemDeOrdenDeCompraMSLista DevuelveTodosItemDeOrdenDeCompraes(ItemDeOrdenDeCompraME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IItemDeOrdenDeCompraActor>().ObtenerListaItemDeOrdenDeCompra();
        var listaMS =
            lista.Transformar(itemDeOrdenDeCompra =>
            new ItemDeOrdenDeCompraMS(itemDeOrdenDeCompra.ItemDeOrdenDeCompraID,
                                    itemDeOrdenDeCompra.OrdenDeCompraID,
                                    itemDeOrdenDeCompra.ProductoID,
                                    itemDeOrdenDeCompra.CantidadOrdenada,
                                    itemDeOrdenDeCompra.PrecioUnitario));
        return new ItemDeOrdenDeCompraMSLista(listaMS.ToArray());
    }
}
