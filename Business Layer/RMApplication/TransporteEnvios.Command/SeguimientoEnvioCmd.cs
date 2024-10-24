using RMMensajeria.TransporteEnvios;
using TransporteEnvios.Command.Interfaces;
using TransporteEnvios.Entidad;
using TransporteEnvios.Interfaces;
using Utilidades;

namespace TransporteEnvios.Command;

public class SeguimientoEnvioCmd : ISeguimientoEnvioCmd
{
    private readonly IGestorId _gestorId;
    public SeguimientoEnvioCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public SeguimientoEnvioMS NuevoSeguimientoEnvio(SeguimientoEnvioME mensajeEntrada)
    {
        var nuevoEnvio =
            new SeguimientoEnvio(mensajeEntrada.SeguimientoID,
                     mensajeEntrada.OrdenEnvioID,
                     mensajeEntrada.FechaRegistro,
                     mensajeEntrada.Estado,
                     mensajeEntrada.UbicacionActual,
                     mensajeEntrada.Comentarios,
                     mensajeEntrada.FechaCreacion,
                     mensajeEntrada.FechaActualizacion);

        _gestorId.Resuelve<ISeguimientoEnvioActor>().ProcesaInsertar(nuevoEnvio);

        return new SeguimientoEnvioMS
               (nuevoEnvio.SeguimientoID,
                nuevoEnvio.OrdenEnvioID,
                nuevoEnvio.FechaRegistro,
                nuevoEnvio.Estado,
                nuevoEnvio.UbicacionActual,
                nuevoEnvio.Comentarios,
                nuevoEnvio.FechaCreacion,
                nuevoEnvio.FechaActualizacion);
    }

    public SeguimientoEnvioMS EliminarSeguimientoEnvio(SeguimientoEnvioME mensajeEntrada)
    {
        var seguimientoEnvioActor = _gestorId.Resuelve<IRutaActor>();
        var seguimientoEnvio = _gestorId.Resuelve<IRutaActor>().ObtenerRutaPorId(mensajeEntrada.OrdenEnvioID);

        seguimientoEnvioActor.ProcesaEliminar(seguimientoEnvio);

        return new SeguimientoEnvioMS();
    }
}
