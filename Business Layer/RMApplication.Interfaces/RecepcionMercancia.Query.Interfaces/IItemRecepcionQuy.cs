using RMMensajeria.RecepcionMercancia;
using static RMMensajeria.RecepcionMercancia.ItemsRecepcionMS;

namespace RecepcionMercancia.Query.Interfaces;

public interface IItemRecepcionQuy
{
    ItemsRecepcionMS DevuelveItemRecepcion(ItemsRecepcionME mensajeEntrada);
    ItemsRecepcionesMSLista DevuelveTodosItemRecepciones(ItemsRecepcionME mensajeEntrada);
}
