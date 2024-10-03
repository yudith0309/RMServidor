using TransporteEnvios.Entidad;

namespace TransporteEnvios.Interfaces;

public interface ITransportistasActor
{
    Transportista ObtenerTransportistasPorId(Guid id);
    List<Transportista> ObtenerListaTransportista();
    void ProcesaInsertar(Transportista transportista);
    void ProcesaEliminar(Transportista transportista);
}
