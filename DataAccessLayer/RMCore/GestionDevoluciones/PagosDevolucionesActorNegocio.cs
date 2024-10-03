using GestionDevoluciones.Entidad;

namespace GestionDevoluciones;

public partial class PagosDevolucionesActor
{
    public void ProcesaInsertar(PagosDevoluciones pagosDevoluciones)
    {
        _repository.Agregar(pagosDevoluciones);

    }

    public void ProcesaEliminar(PagosDevoluciones pagosDevoluciones)
    {
        _repository.Eliminar(pagosDevoluciones);
    }

}
