namespace Utilidades;

public static class Extensiones
{
    public static void ListasDoblesRange<T>(this List<T> primera, List<T> segunda)
    {
        if (segunda != null && primera != null)
        {
            primera.AddRange(segunda);
        }
    }

    // Método de extensión genérico para transformar una lista y devolver una nueva lista
    public static List<TOutput> Transformar<TInput, TOutput>(this IEnumerable<TInput> lista, Func<TInput, TOutput> transformacion)
    {
        return lista.Select(transformacion).ToList();
    }
}
