using RMMensajeria.GestionProveedores;

namespace GestionProveedores.Command.Interfaces;

public interface IProveedorCmd
{
    ProveedorMS NuevoProveedor(ProveedorME mensajeEntrada);
    ProveedorMS EliminarProveedor(ProveedorME mensajeEntrada);
}
