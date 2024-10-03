using GestionProveedores.Entidad;

namespace GestionProveedores;

public partial class ProveedorActor
{
    public void ProcesaInsertar(Proveedor proveedor)
    {
        _repository.Agregar(proveedor);

    }
    public void ProcesaEliminar(Proveedor proveedor)
    {
        _repository.Eliminar(proveedor);
    }
}
