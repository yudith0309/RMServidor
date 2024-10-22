using RecepcionMercancia.Interfaces;
using RecepcionMercancia.Query.Interfaces;
using RMMensajeria.RecepcionMercancia;
using Utilidades;
using static RMMensajeria.RecepcionMercancia.ItemsRecepcionMS;

namespace RecepcionMercancia.Query;

public class ItemRecepcionQuy : IItemRecepcionQuy
{
    private readonly IGestorId _gestorId;

    public ItemRecepcionQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public ItemsRecepcionMS DevuelveItemRecepcion(ItemsRecepcionME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IItemsRecepcionActor>().ObtenerItemsRecepcionPorId(mensajeEntrada.RecepccionItemID);
        return new ItemsRecepcionMS
        {
            RecepccionItemID = salida.RecepccionItemID,
            RecepcionID = salida.RecepcionID,
            ProductoID = salida.ProductoID,
            CantidadRecibida = salida.CantidadRecibida,
            Condicion = salida.Condicion,
            Comentarios = salida.Comentarios
        };
    }

    public ItemsRecepcionesMSLista DevuelveTodosItemRecepciones(ItemsRecepcionME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IItemsRecepcionActor>().ObtenerListaItemsRecepcion();
        var listaMS =
            lista.Transformar(recepcion =>
            new ItemsRecepcionMS(recepcion.RecepccionItemID,
                                 recepcion.RecepcionID,
                                 recepcion.ProductoID,
                                 recepcion.CantidadRecibida,
                                 recepcion.Condicion,
                                 recepcion.Comentarios));        

        return new ItemsRecepcionesMSLista(listaMS.ToArray());

    }

}
