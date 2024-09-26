namespace Utilidades;

public  static class Extensiones
{
    public static void ListasDoblesRange<T>(this List<T> primera, List<T> segunda)
    {
        if (segunda != null && primera != null)
        {
            primera.AddRange(segunda);
        }
    }
}
