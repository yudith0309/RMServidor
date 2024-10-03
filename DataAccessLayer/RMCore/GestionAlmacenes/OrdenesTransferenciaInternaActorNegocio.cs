using GestionAlmacenes.Entidad;

namespace GestionAlmacenes;

public partial class OrdenesTransferenciaInternaActor
{
    public void ProcesaInsertar(OrdenesTransferenciaInterna ordenesTransferencia)
    {
        _repository.Agregar(ordenesTransferencia);

    }

    public void ProcesaEliminar(OrdenesTransferenciaInterna ordenesTransferencia)
    {
        _repository.Eliminar(ordenesTransferencia);
    }
}
