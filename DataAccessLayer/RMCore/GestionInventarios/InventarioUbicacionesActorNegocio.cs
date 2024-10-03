using GestionInventarios.Entidad;

namespace GestionInventarios;

public partial class InventarioUbicacionesActor
{
    public void ProcesaInsertar(InventarioUbicaciones inventarioUbicaciones)
    {
        _repository.Agregar(inventarioUbicaciones);

    }

    public void ProcesaEliminar(InventarioUbicaciones inventarioUbicaciones)
    {
        _repository.Eliminar(inventarioUbicaciones);
    }
}
