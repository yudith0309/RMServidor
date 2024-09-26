using RecepcionMercancia.Entidad;

namespace RecepcionMercancia;

public interface IProductoActor
{
    Producto ObtenerProductoPorId(Guid id);
    void ProcesaInsertar(Producto producto);
    Producto ProcesaActualizar(Guid producto, string codigo, string nombre, string descripcion, string um, DateTime fechaCreacion, DateTime fechaActualizacion);
}
