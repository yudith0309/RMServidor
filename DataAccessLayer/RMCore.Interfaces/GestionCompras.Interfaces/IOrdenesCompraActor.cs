using GestionCompras.Entidad;

namespace GestionCompras.Interfaces;

public interface IOrdenesCompraActor
{
    OrdenesCompra ObtenerOrdenesCompraPorId(Guid id);
    List<OrdenesCompra> ObtenerListaOrdenesCompra();
    void ProcesaInsertar(OrdenesCompra ordenesCompra);
    void ProcesaEliminar(OrdenesCompra ordenesCompra);
}
