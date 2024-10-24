using RMMensajeria.TransporteEnvios;

namespace TransporteEnvios.Query.Interfaces;

public interface ISeguimientoEnvioQuy
{
    SeguimientoEnvioMS DevuelveSeguimientoEnvio(SeguimientoEnvioME mensajeEntrada);
    SeguimientoEnvioMSLista DevuelveTodosSeguimientoEnvio(SeguimientoEnvioME mensajeEntrada);
}
