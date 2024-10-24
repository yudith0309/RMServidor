using RMMensajeria.TransporteEnvios;

namespace TransporteEnvios.Command.Interfaces;

public interface ITransportistaCmd
{
    TransportistasMS NuevoTransportistas(TransportistasME mensajeEntrada);
    TransportistasMS EliminarTransportistas(TransportistasME mensajeEntrada);
}
