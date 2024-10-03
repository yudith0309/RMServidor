using GestionDevoluciones.Entidad;

namespace GestionDevoluciones.Interfaces;

public interface IDevolucionesActor
{
    Devoluciones ObtenerDevolucionesPorId(Guid id);
    List<Devoluciones> ObtenerListaDevoluciones();
    void ProcesaInsertar(Devoluciones devoluciones);
    void ProcesaEliminar(Devoluciones devoluciones);
}
