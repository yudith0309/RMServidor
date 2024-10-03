using TransporteEnvios.Entidad;

namespace TransporteEnvios;

public partial class SeguimientoEnvioActor
{
    public void ProcesaInsertar(SeguimientoEnvio seguimientoEnvio)
    {
        _repository.Agregar(seguimientoEnvio);

    }

    public void ProcesaEliminar(SeguimientoEnvio seguimientoEnvio)
    {
        _repository.Eliminar(seguimientoEnvio);
    }
}
