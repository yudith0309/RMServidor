using GestionAlmacenes.Entidad;

namespace GestionAlmacenes;

public partial class AlmacenActor
{
    public void ProcesaInsertar(Almacen almacen)
    {
        _repository.Agregar(almacen);

    }

    public void ProcesaEliminar(Almacen almacen)
    {
        _repository.Eliminar(almacen);
    }
}
