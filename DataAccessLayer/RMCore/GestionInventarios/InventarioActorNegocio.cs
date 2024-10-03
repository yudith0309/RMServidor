namespace GestionInventarios;
using GestionInventarios.Entidad;

public partial class InventarioActor
{
    public void ProcesaInsertar(Inventario inventario)
    {
        _repository.Agregar(inventario);

    }
    public void ProcesaEliminar(Inventario inventario)
    {
        _repository.Eliminar(inventario);
    }
}
