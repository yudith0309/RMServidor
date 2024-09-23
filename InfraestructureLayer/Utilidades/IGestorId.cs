namespace Utilidades;

public interface IGestorId
{
    bool EsQuery { get; }
    T GetValue<T>() where T : class;
}
