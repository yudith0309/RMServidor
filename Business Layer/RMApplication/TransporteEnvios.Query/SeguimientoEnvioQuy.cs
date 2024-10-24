using RMMensajeria.TransporteEnvios;
using TransporteEnvios.Interfaces;
using TransporteEnvios.Query.Interfaces;
using Utilidades;

namespace TransporteEnvios.Query;

public class SeguimientoEnvioQuy: ISeguimientoEnvioQuy
{
    private readonly IGestorId _gestorId;
    public SeguimientoEnvioQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public SeguimientoEnvioMS DevuelveSeguimientoEnvio(SeguimientoEnvioME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<ISeguimientoEnvioActor>().ObtenerSeguimientoEnvioPorId(mensajeEntrada.SeguimientoID);
        return new SeguimientoEnvioMS
        {
            SeguimientoID = salida.SeguimientoID,
            OrdenEnvioID = salida.OrdenEnvioID,
            FechaRegistro = salida.FechaRegistro,
            Estado = salida.Estado,
            UbicacionActual = salida.UbicacionActual,
            Comentarios = salida.Comentarios,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };
    }

    public SeguimientoEnvioMSLista DevuelveTodosSeguimientoEnvio(SeguimientoEnvioME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<ISeguimientoEnvioActor>().ObtenerListaSeguimientoEnvio();
        var listaMS =
            lista.Transformar(seguimientoEnvio =>
            new SeguimientoEnvioMS(seguimientoEnvio.SeguimientoID,
                        seguimientoEnvio.OrdenEnvioID,
                        seguimientoEnvio.FechaRegistro,
                        seguimientoEnvio.Estado,
                        seguimientoEnvio.UbicacionActual,
                        seguimientoEnvio.Comentarios,
                        seguimientoEnvio.FechaCreacion,
                        seguimientoEnvio.FechaActualizacion));
        return new SeguimientoEnvioMSLista(listaMS.ToArray());

    }
}
