using GestionInventarios.Entidad;

namespace GestionInventarios.Interfaces;

public interface IInventarioActor
{
    Inventario ObtenerInventarioPorId(Guid id);
    List<Inventario> ObtenerListaInventario();
    void ProcesaInsertar(Inventario inventario);
    void ProcesaEliminar(Inventario inventario);
}
