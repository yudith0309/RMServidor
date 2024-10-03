using RecepcionMercancia.Entidad;

namespace RecepcionMercancia;

public partial class RecepcionActor
{
    public void ProcesaInsertar(Recepcion recepcion)
    {
        _repository.Agregar(recepcion);

    }
    public void ProcesaEliminar(Recepcion recepcion)
    {
        _repository.Eliminar(recepcion);
    }
}
