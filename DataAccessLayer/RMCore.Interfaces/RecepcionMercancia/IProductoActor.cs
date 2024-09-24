namespace RecepcionMercancia;

public interface IProductoActor
{
    Task<List<Producto>> ObtenerTodosLosProductos();
    void ProcesaInsertarpoducto(Producto producto);
    void ActualizarProducto(Producto producto);
}
