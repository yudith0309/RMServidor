namespace RecepcionMercancia;

public interface IProductoActor
{
    Producto ObtenerProductoPorId(Guid id);
    void ProcesaInsertar(Producto producto);
    void ProcesaActualizar(Producto producto);
}
