using RMMensajeria.TransporteEnvios;
using TransporteEnvios.Command.Interfaces;
using TransporteEnvios.Entidad;
using TransporteEnvios.Interfaces;
using Utilidades;

namespace TransporteEnvios.Command;

public class RutasCmd: IRutasCmd
{
    private readonly IGestorId _gestorId;
    public RutasCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public RutasMS NuevoRutas(RutasME mensajeEntrada)
    {
        var nuevoRuta =
            new Ruta(mensajeEntrada.RutaID,
                     mensajeEntrada.OrdenEnvioID,
                     mensajeEntrada.PuntoSalida,
                     mensajeEntrada.PuntoDestino,
                     mensajeEntrada.Distancia,
                     mensajeEntrada.TiempoEstimado,
                     mensajeEntrada.FechaCreacion,
                     mensajeEntrada.FechaActualizacion);

        _gestorId.Resuelve<IRutaActor>().ProcesaInsertar(nuevoRuta);

        return new RutasMS
               (nuevoRuta.RutaID,
                nuevoRuta.OrdenEnvioID,
                nuevoRuta.PuntoSalida,
                nuevoRuta.PuntoDestino,
                nuevoRuta.Distancia,
                nuevoRuta.TiempoEstimado,
                nuevoRuta.FechaCreacion,
                nuevoRuta.FechaActualizacion);
    }

    public RutasMS EliminarRutas(RutasME mensajeEntrada)
    {
        var rutasActor = _gestorId.Resuelve<IRutaActor>();
        var rutas = _gestorId.Resuelve<IRutaActor>().ObtenerRutaPorId(mensajeEntrada.OrdenEnvioID);

        rutasActor.ProcesaEliminar(rutas);

        return new RutasMS();
    }
}
