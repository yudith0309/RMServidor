using GestionAlmacenes.Entidad;

namespace GestionAlmacenes;

public partial class ZonasAlmacenActor
{
    public void ProcesaInsertar(ZonasAlmacen zonasAlmacen)
    {
        _repository.Agregar(zonasAlmacen);

    }

    public void ProcesaEliminar(ZonasAlmacen zonasAlmacen)
    {
        _repository.Eliminar(zonasAlmacen);
    }
}
