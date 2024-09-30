namespace AccesDataBase.Repository;

public interface IRepository
{
    T ObtenerPorId<T>(Guid id) where T : class;
    List<T> ObtenerTodos<T>() where T : class;
    void Agregar<T>(T entidad) where T : class;
    void Actualizar<T>(T entidad) where T : class;
    void Eliminar<T>(T entidad) where T : class;
}
