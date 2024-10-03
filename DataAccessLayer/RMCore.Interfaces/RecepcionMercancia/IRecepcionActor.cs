using RecepcionMercancia.Entidad;

namespace RecepcionMercancia.Interfaces;

public interface IRecepcionActor
{
    Recepcion ObtenerRecepcionPorId(Guid id);
    List<Recepcion> ObtenerListaRecepcion();
    void ProcesaInsertar(Recepcion recepcion);
    void ProcesaEliminar(Recepcion recepcion);
}
