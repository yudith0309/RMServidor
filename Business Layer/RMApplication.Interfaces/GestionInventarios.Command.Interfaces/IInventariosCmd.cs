using RMMensajeria.GestionInventarios;

namespace GestionInventarios.Command.Interfaces;

public interface IInventariosCmd
{
    InventariosMS NuevoInventarios(InventariosME mensajeEntrada);
    InventariosMS EliminarInventarios(InventariosME mensajeEntrada);
}
