using GestionDevoluciones.Entidad;

namespace GestionDevoluciones;

public partial class DevolucionesActor
{
    public void ProcesaInsertar(Devoluciones devoluciones)
    {
        _repository.Agregar(devoluciones);

    }

    public void ProcesaEliminar(Devoluciones devoluciones)
    {
        _repository.Eliminar(devoluciones);
    }
}
