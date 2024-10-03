using TransporteEnvios.Entidad;

namespace TransporteEnvios.Interfaces;

public interface IOrdenesEnvioActor
{
    OrdenesEnvio ObtenerOrdenesEnvioPorId(Guid id);
    List<OrdenesEnvio> ObtenerListaOrdenesEnvio();
    void ProcesaInsertar(OrdenesEnvio ordenesEnvio);
    void ProcesaEliminar(OrdenesEnvio ordenesEnvio);
}
