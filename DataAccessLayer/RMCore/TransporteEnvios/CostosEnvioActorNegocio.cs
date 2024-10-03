using TransporteEnvios.Entidad;

namespace TransporteEnvios;

public partial class CostosEnvioActor
{
    public void ProcesaInsertar(CostosEnvio costoEnvio)
    {
        _repository.Agregar(costoEnvio);

    }
    public void ProcesaEliminar(CostosEnvio costosEnvio)
    {
        _repository.Eliminar(costosEnvio);
    }
}
