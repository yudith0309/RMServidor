namespace Utilidades;
public class GestorId : IGestorId
{
    private readonly IServiceProvider _serviceProvider;

    public GestorId(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    public T Resuelve<T>() where T : class
    {
        var servicio = _serviceProvider.GetService(typeof(T)) as T;
        if (servicio == null)
        {
            throw new InvalidOperationException($"El servicio del tipo {typeof(T).Name} no está registrado.");
        }
        return servicio;
    }
  
}
