using RMMensajeria.TransporteEnvios;
using TransporteEnvios.Interfaces;
using TransporteEnvios.Query.Interfaces;
using Utilidades;

namespace TransporteEnvios.Query;

public class RutasQuy: IRutasQuy
{
    private readonly IGestorId _gestorId;

    public RutasQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public RutasMS DevuelveRutas(RutasME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IRutaActor>().ObtenerRutaPorId(mensajeEntrada.RutaID);
        return new RutasMS
        {
            RutaID = salida.RutaID,
            OrdenEnvioID = salida.OrdenEnvioID,
            PuntoSalida = salida.PuntoSalida,
            PuntoDestino = salida.PuntoDestino,
            Distancia = salida.Distancia,
            TiempoEstimado = salida.TiempoEstimado,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };
    }

    public RutasMSLista DevuelveTodosRutas(RutasME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IRutaActor>().ObtenerListaRuta();
        var listaMS =
            lista.Transformar(rutas =>
            new RutasMS(rutas.RutaID,
                        rutas.OrdenEnvioID,
                        rutas.PuntoSalida,
                        rutas.PuntoDestino,
                        rutas.Distancia,
                        rutas.TiempoEstimado,
                        rutas.FechaCreacion,
                        rutas.FechaActualizacion));
        return new RutasMSLista(listaMS.ToArray());

    }
}
