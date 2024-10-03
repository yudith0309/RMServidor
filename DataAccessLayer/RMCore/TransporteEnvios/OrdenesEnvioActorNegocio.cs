using TransporteEnvios.Entidad;

namespace TransporteEnvios;

public partial class OrdenesEnvioActor
{
    public void ProcesaInsertar(OrdenesEnvio ordenesEnvio)
    {
        _repository.Agregar(ordenesEnvio);

    }
    public void ProcesaEliminar(OrdenesEnvio ordenesEnvio)
    {
        _repository.Eliminar(ordenesEnvio);
    }
}
