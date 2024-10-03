using TransporteEnvios.Entidad;

namespace TransporteEnvios;

public partial class RutaActor
{
    public void ProcesaInsertar(Ruta ruta)
    {
        _repository.Agregar(ruta);

    }
    public void ProcesaEliminar(Ruta ruta)
    {
        _repository.Eliminar(ruta);
    }
}
