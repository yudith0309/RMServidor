using GestionPedidos.Entidad;

namespace GestionPedidos.Interfaces;

public interface IPagosActor
{
    Pagos ObtenerPagosPorId(Guid id);
    List<Pagos> ObtenerListaPagos();
    void ProcesaInsertar(Pagos pagos);
    void ProcesaEliminar(Pagos pagos);
}
