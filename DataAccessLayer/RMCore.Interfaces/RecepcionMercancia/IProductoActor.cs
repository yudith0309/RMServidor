using RecepcionMercancia.Entidad;

namespace RecepcionMercancia.Interfaces;

public interface IProductoActor
{
    Producto ObtenerProductoPorId(Guid id);
    List<Producto> ObtenerListaProducto();
    void ProcesaInsertar(Producto producto);
    Producto ProcesaActualizar(Guid producto, string codigo, string nombre, string descripcion, string um, DateTime fechaCreacion, DateTime fechaActualizacion);
    void ProcesaEliminar(Producto producto);
}
