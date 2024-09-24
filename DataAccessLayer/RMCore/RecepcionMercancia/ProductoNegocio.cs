namespace RecepcionMercancia;

public partial class ProductoActor
{
    public void ProcesaInsertar(Producto producto)
    {
        _repository.Agregar(producto);

    }
    public void ProcesaActualizar(Producto producto)
    {
        _repository.Actualizar(producto);
    }
}
