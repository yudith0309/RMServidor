using GestionAlmacenes.Entidad;

namespace GestionAlmacenes.Interfaces;

public interface IAlmacenActor
{
    Almacen ObtenerAlmacenPorId(Guid id);
    List<Almacen> ObtenerListaAlmacen();
    void ProcesaInsertar(Almacen almacen);
    void ProcesaEliminar(Almacen almacen);
}
