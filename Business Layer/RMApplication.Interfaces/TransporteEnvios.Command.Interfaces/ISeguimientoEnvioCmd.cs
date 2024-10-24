using RMMensajeria.TransporteEnvios;

namespace TransporteEnvios.Command.Interfaces;

public interface ISeguimientoEnvioCmd
{
    SeguimientoEnvioMS NuevoSeguimientoEnvio(SeguimientoEnvioME mensajeEntrada);
    SeguimientoEnvioMS EliminarSeguimientoEnvio(SeguimientoEnvioME mensajeEntrada);
}
