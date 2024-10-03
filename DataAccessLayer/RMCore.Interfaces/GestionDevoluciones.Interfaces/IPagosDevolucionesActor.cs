using GestionDevoluciones.Entidad;

namespace GestionDevoluciones.Interfaces;

public interface IPagosDevolucionesActor
{
    PagosDevoluciones ObtenerPagosDevolucionesPorId(Guid id);
    List<PagosDevoluciones> ObtenerListaPagosDevoluciones();
    void ProcesaInsertar(PagosDevoluciones pagosDevoluciones);
    void ProcesaEliminar(PagosDevoluciones pagosDevoluciones);
}
