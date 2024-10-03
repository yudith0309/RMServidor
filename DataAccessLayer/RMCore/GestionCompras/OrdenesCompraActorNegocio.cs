using GestionCompras.Entidad;

namespace GestionCompras;

public partial class OrdenesCompraActor
{
    public void ProcesaInsertar(OrdenesCompra ordenesCompra)
    {
        _repository.Agregar(ordenesCompra);

    }
    public void ProcesaEliminar(OrdenesCompra ordenesCompra)
    {
        _repository.Eliminar(ordenesCompra);
    }
}
