using GestionAlmacenes.Entidad;

namespace GestionAlmacenes;

public partial class UbicacionesActor
{
    public void ProcesaInsertar(Ubicacion ubicacion)
    {
        _repository.Agregar(ubicacion);

    }
    public void ProcesaEliminar(Ubicacion ubicacion)
    {
        _repository.Eliminar(ubicacion);
    }
}
