namespace Utilidades;

public interface IGestorId
{
    T Resuelve<T>() where T : class;
}
