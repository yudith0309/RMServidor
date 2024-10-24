using RMMensajeria.TransporteEnvios;

namespace TransporteEnvios.Query.Interfaces;

public interface IRutasQuy
{
    RutasMS DevuelveRutas(RutasME mensajeEntrada);
    RutasMSLista DevuelveTodosRutas(RutasME mensajeEntrada);
}
