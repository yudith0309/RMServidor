using TransporteEnvios.Entidad;

namespace TransporteEnvios.Interfaces;

public interface IRutaActor
{
    Ruta ObtenerRutaPorId(Guid id);
    List<Ruta> ObtenerListaRuta();
    void ProcesaInsertar(Ruta ruta);
    void ProcesaEliminar(Ruta ruta);
}
