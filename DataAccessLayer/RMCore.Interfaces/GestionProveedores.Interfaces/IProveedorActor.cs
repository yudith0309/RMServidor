using GestionProveedores.Entidad;

namespace GestionProveedores.Interfaces;

public interface IProveedorActor
{
    Proveedor ObtenerProveedorPorId(Guid id);
    List<Proveedor> ObtenerListaProveedor();
    void ProcesaInsertar(Proveedor proveedor);
    void ProcesaEliminar(Proveedor proveedor);
}
