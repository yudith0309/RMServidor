using GestionProveedores.Entidad;

namespace GestionProveedores.Interfaces;

public interface IPagosProveedoresActor
{
    PagosProveedores ObtenerPagosProveedoresPorId(Guid id);
    List<PagosProveedores> ObtenerListaPagosProveedores();
    void ProcesaInsertar(PagosProveedores pagosProveedores);
    void ProcesaEliminar(PagosProveedores pagosProveedores);
}
