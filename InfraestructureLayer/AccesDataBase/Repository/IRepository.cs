using RecepcionMercancia;
using System.Linq.Expressions;

namespace AccesDataBase.Repository;

public interface IRepository<T>
{
    Task<T> ObtenerPorId(Expression<Func<T, bool>> condicion);
    Task<List<Producto>> ObtenerListado();
    Task<List<T>> ObtenerListaPorCondicion(Expression<Func<T, bool>> condicion);
    Task Insertar(T entidad);
    Task EliminarEntidad(T entidad);
    Task EliminarPorId<TKey>(TKey id);
    Task Actualizar(T entidad);
}
