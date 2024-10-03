using GestionProveedores.Entidad;

namespace GestionProveedores;

public partial class PagosProveedoresActor
{
    public void ProcesaInsertar(PagosProveedores pagosProveedores)
    {
        _repository.Agregar(pagosProveedores);

    }
    public void ProcesaEliminar(PagosProveedores pagosProveedores)
    {
        _repository.Eliminar(pagosProveedores);
    }
}
