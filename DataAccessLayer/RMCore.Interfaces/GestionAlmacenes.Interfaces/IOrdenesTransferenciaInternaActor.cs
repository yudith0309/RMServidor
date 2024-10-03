using GestionAlmacenes.Entidad;

namespace GestionAlmacenes.Interfaces;

public interface IOrdenesTransferenciaInternaActor
{
    OrdenesTransferenciaInterna ObtenerOrdenesTransferenciaPorId(Guid id);
    List<OrdenesTransferenciaInterna> ObtenerListaOrdenesTransferencia();
    void ProcesaInsertar(OrdenesTransferenciaInterna ordenesTransferencia);
    void ProcesaEliminar(OrdenesTransferenciaInterna ordenesTransferencia);
}
