using RMMensajeria.TransporteEnvios;

namespace TransporteEnvios.Command.Interfaces;

public interface IRutasCmd
{
    RutasMS NuevoRutas(RutasME mensajeEntrada);
    RutasMS EliminarRutas(RutasME mensajeEntrada);
}
