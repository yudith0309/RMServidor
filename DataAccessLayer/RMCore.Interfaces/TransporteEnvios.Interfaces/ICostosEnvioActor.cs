using TransporteEnvios.Entidad;

namespace TransporteEnvios.Interfaces;

public interface ICostosEnvioActor
{
    CostosEnvio ObtenerCostosEnvioPorId(Guid id);
    List<CostosEnvio> ObtenerListaCostosEnvio();
    void ProcesaInsertar(CostosEnvio costoEnvio);
    void ProcesaEliminar(CostosEnvio costosEnvio);
}
