using GestionAlmacenes.Entidad;

namespace GestionAlmacenes.Interfaces;

public interface IZonasAlmacenActor
{
    ZonasAlmacen ObtenerZonasAlmacenPorId(Guid id);
    List<ZonasAlmacen> ObtenerListaZonasAlmacen();
    void ProcesaInsertar(ZonasAlmacen zonasAlmacen);
    void ProcesaEliminar(ZonasAlmacen zonasAlmacen);
}
