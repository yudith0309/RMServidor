using GestionAlmacenes.Entidad;

namespace GestionAlmacenes.Interfaces;

public interface IUbicacionesActor
{
    Ubicacion ObtenerUbicacionesPorId(Guid id);
    List<Ubicacion> ObtenerListaUbicaciones();
    void ProcesaInsertar(Ubicacion ubicacion);
    void ProcesaEliminar(Ubicacion ubicacion);
}
