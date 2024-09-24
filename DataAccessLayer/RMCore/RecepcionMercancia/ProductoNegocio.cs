namespace RecepcionMercancia;

public partial class ProductoActor
{
    public void ProcesaInsertarpoducto(Producto producto)
    {
        _productoRepository.Insertar(producto);

    }
    public void ActualizarProducto(Producto producto)
    {
        _productoRepository.Actualizar(producto);
    }
}
