using RMMensajeria.TransporteEnvios;
using TransporteEnvios.Entidad;

namespace TransporteEnvios.Query.Interfaces;
public interface ICostosEnvioQuy
{
    CostosEnvioMS DevuelveCostosEnvio(CostosEnvioME mensajeEntrada);
    CostosEnvioMSLista DevuelveTodosCostosEnvio(CostosEnvioME mensajeEntrada);
}
