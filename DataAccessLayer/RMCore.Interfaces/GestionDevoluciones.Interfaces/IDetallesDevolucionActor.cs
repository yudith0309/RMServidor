using GestionDevoluciones.Entidad;

namespace GestionDevoluciones.Interfaces;

public interface IDetallesDevolucionActor
{
    DetallesDevolucion ObtenerDetallesDevolucionPorId(Guid id);
    List<DetallesDevolucion> ObtenerListaDetallesDevolucion();
    void ProcesaInsertar(DetallesDevolucion detallesDevolucion);
    void ProcesaEliminar(DetallesDevolucion detallesDevolucion);
}
