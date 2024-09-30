using AccesDataBase.Repository;
using RecepcionMercancia.Entidad;
using RecepcionMercancia.Interfaces;
using Utilidades;

namespace RecepcionMercancia;

public partial class ProductoActor : IProductoActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public ProductoActor(IRepository productoRepository, IGestorId gestorId)
    {
        _repository = productoRepository;
        _gestorId = gestorId;
    }
    public Producto ObtenerProductoPorId(Guid id)
    {
        return _repository.ObtenerPorId<Producto>(id);
    }

    public List<Producto> ObtenerListaProducto()
    {
        var listaProducto = new List<Producto>();
        listaProducto = _repository.ObtenerTodos<Producto>();
        return listaProducto;
    }
}
