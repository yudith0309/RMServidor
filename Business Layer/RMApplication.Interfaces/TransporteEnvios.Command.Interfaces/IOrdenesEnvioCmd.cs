using RMMensajeria.TransporteEnvios;

namespace TransporteEnvios.Command.Interfaces;

public interface IOrdenesEnvioCmd
{
    OrdenesEnvioMS NuevoOrdenesEnvio(OrdenesEnvioME mensajeEntrada);
    OrdenesEnvioMS EliminarOrdenesEnvio(OrdenesEnvioME mensajeEntrada);
}
