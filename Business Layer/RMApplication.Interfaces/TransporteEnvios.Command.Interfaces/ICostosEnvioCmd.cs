using RMMensajeria.TransporteEnvios;

namespace TransporteEnvios.Command.Interfaces;

public interface ICostosEnvioCmd
{
    CostosEnvioMS NuevoCostosEnvio(CostosEnvioME mensajeEntrada);
    CostosEnvioMS EliminarCostosEnvio(CostosEnvioME mensajeEntrada);
}
