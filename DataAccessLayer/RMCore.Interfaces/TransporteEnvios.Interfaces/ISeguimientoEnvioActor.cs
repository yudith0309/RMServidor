using TransporteEnvios.Entidad;

namespace TransporteEnvios.Interfaces;

public interface ISeguimientoEnvioActor
{
    SeguimientoEnvio ObtenerSeguimientoEnvioPorId(Guid id);
    List<SeguimientoEnvio> ObtenerListaSeguimientoEnvio();
    void ProcesaInsertar(SeguimientoEnvio seguimientoEnvio);
    void ProcesaEliminar(SeguimientoEnvio seguimientoEnvio);
}
