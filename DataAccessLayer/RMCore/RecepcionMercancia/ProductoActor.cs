using AccesDataBase.Repository;

namespace RecepcionMercancia;

public partial class ProductoActor: IProductoActor
{
    private readonly IRepository<Producto> _productoRepository;

    public ProductoActor(IRepository<Producto> productoRepository)
    {
        _productoRepository = productoRepository;
    }
    public async Task<List<Producto>> ObtenerTodosLosProductos()
    {
        var productos = await _productoRepository.ObtenerListado();
        return productos;
    }
}
