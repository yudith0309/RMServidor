using Utilidades;

namespace Servicios;

public class ProductoCmd
{
    private readonly IGestorId _gestorId;
    public ProductoCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
}
