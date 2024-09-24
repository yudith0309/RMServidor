using AccesDataBase.Repository;

namespace RecepcionMercancia;

public partial class ProductoActor: IProductoActor
{
    private readonly IRepository _repository;

    public ProductoActor(IRepository productoRepository)
    {
        _repository = productoRepository;
    }
    public Producto ObtenerProductoPorId(Guid id)
    {
        return _repository.ObtenerPorId<Producto>(id);
    }
}
