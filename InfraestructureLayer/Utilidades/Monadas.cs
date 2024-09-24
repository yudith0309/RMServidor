namespace Utilidades;

public static class Monadas
{
    public static TOut Pipe<TIn, TOut>(this TIn v, Func<TIn, TOut> FnOut) where TIn : struct where TOut : struct
    {
        return FnOut(v);
    }

    public static TOut PipeClass<TIn, TOut>(this TIn v, Func<TIn, TOut> FnOut) where TIn : class where TOut : class
    {
        return FnOut(v);
    }
}
