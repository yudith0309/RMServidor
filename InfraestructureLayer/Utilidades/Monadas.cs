namespace Utilidades;

public static class Monadas
{
    //Para metodos varios metodos que devuelven distintas operaciones
    public static TOut Pipe<TIn, TOut>(this TIn v, Func<TIn, TOut> FnOut) where TIn : struct where TOut : struct
    {
        return FnOut(v);
    }

    //Para clases vaias condiciones  
    public static TOut PipeClass<TIn, TOut>(this TIn v, Func<TIn, TOut> FnOut) where TIn : class where TOut : class
    {
        return FnOut(v);
    }

}
