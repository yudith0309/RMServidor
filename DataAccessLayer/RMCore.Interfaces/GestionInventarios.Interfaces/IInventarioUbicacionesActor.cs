using GestionInventarios.Entidad;

namespace GestionInventarios.Interfaces;

public interface IInventarioUbicacionesActor
{
    InventarioUbicaciones ObtenerInventarioUbicacionesPorId(Guid id);
    List<InventarioUbicaciones> ObtenerListaInventarioUbicaciones();
    void ProcesaInsertar(InventarioUbicaciones inventarioUbicaciones);
    void ProcesaEliminar(InventarioUbicaciones inventarioUbicaciones);
}
