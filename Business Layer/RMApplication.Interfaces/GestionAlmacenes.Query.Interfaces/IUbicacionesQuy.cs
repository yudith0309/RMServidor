using RMMensajeria.GestionAlmacenes;

namespace GestionAlmacenes.Query.Interfaces;

public interface IUbicacionesQuy
{
    UbicacionesMS DevuelveUbicaciones(UbicacionesME mensajeEntrada);
    UbicacionesMSLista DevuelveTodosUbicacionesAlmacenes(AlmacenME mensajeEntrada);
}
