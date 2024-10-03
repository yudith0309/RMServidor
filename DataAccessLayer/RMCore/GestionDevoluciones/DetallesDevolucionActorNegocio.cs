using GestionDevoluciones.Entidad;

namespace GestionDevoluciones;

public partial class DetallesDevolucionActor
{
    public void ProcesaInsertar(DetallesDevolucion detallesDevolucion)
    {
        _repository.Agregar(detallesDevolucion);

    }
    public void ProcesaEliminar(DetallesDevolucion detallesDevolucion)
    {
        _repository.Eliminar(detallesDevolucion);
    }
}
