using RMMensajeria.GestionProveedores;

namespace GestionProveedores.Command.Interfaces;

public interface IPagosProveedoresCmd
{
    PagosProveedoresMS NuevoPagosProveedor(PagosProveedoresME mensajeEntrada);
    PagosProveedoresMS EliminarPagosProveedor(PagosProveedoresME mensajeEntrada);
}
