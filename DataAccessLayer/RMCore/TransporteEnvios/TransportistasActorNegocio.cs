using TransporteEnvios.Entidad;

namespace TransporteEnvios;

public partial class TransportistasActor
{
    public void ProcesaInsertar(Transportista transportista)
    {
        _repository.Agregar(transportista);

    }

    public void ProcesaEliminar(Transportista transportista)
    {
        _repository.Eliminar(transportista);
    }
}
