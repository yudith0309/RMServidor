using RMMensajeria.RecepcionMercancia;

namespace RecepcionMercancia.Query.Interfaces;

public interface IRecepcionQuy
{
    RecepcionesMS DevuelveRecepcion(RecepcionesME mensajeEntrada);
    RecepcionesMSLista DevuelveTodosRecepciones(RecepcionesME mensajeEntrada);
}
