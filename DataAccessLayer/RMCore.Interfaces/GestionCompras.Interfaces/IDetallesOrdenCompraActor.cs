using GestionCompras.Entidad;

namespace GestionCompras.Interfaces;

public interface IDetallesOrdenCompraActor
{
    DetallesOrdenCompra ObtenerDetallesOrdenCompraPorId(Guid id);
    List<DetallesOrdenCompra> ObtenerListaDetallesOrdenCompra();
    void ProcesaInsertar(DetallesOrdenCompra detallesOrdenCompra);
    void ProcesaEliminar(DetallesOrdenCompra detallesOrdenCompra);
}
