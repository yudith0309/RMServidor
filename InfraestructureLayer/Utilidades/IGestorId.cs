namespace Utilidades;

public interface IGestorId
{
    bool EsQuery { get; }
    T Resuelve<T>() where T : class;
}
