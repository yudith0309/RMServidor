using RMMensajeria.GestionAlmacenes;

namespace GestionAlmacenes.Query.Interfaces;

public interface IZonasAlmacenQuy
{
    ZonasAlmacenMS DevuelveZonasAlmacen(ZonasAlmacenME mensajeEntrada);
    ZonasAlmacenMSLista DevuelveTodosZonasAlmacenAlmacenes(AlmacenME mensajeEntrada);
}
