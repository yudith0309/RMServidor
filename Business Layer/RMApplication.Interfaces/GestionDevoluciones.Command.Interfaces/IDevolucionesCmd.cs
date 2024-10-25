using RMMensajeria.GestionDevoluciones;

namespace GestionDevoluciones.Command.Interfaces;

public interface IDevolucionesCmd
{
    DevolucionesMS NuevoDevoluciones(DevolucionesME mensajeEntrada);
    DevolucionesMS EliminarDevoluciones(DevolucionesME mensajeEntrada);
}
