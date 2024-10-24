using RMMensajeria.TransporteEnvios;

namespace TransporteEnvios.Query.Interfaces;

public interface ITransportistaQuy
{
    TransportistasMS DevuelveTransportista(TransportistasME mensajeEntrada);
    TransportistasMSLista DevuelveTodosTransportista(TransportistasME mensajeEntrada);
}
