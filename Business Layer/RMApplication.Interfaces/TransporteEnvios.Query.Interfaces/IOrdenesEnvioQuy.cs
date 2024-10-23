using RMMensajeria.TransporteEnvios;

namespace TransporteEnvios.Query.Interfaces;

public interface IOrdenesEnvioQuy
{
    OrdenesEnvioMS DevuelveOrdenesEnvio(OrdenesEnvioME mensajeEntrada);
    OrdenesEnvioMSLista DevuelveTodosOrdenesEnvio(OrdenesEnvioME mensajeEntrada);
}
