using GestionAlmacenes.Command.Interfaces;
using GestionAlmacenes.Entidad;
using GestionAlmacenes.Interfaces;
using RMMensajeria.GestionAlmacenes;
using Utilidades;

namespace GestionAlmacenes.Command;

public class UbicacionesCmd: IUbicacionesCmd
{
    private readonly IGestorId _gestorId;
    public UbicacionesCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public UbicacionesMS NuevoUbicaciones(UbicacionesME mensajeEntrada)
    {
        var nuevoUbicaciones =
            new Ubicacion(mensajeEntrada.UbicacionID,
                          mensajeEntrada.AlmacenID,
                          mensajeEntrada.CodigoUbicacion,
                          mensajeEntrada.TipoUbicacion,
                          mensajeEntrada.CapacidadUbicacion,
                          mensajeEntrada.Ocupado,
                          mensajeEntrada.FechaCreacion,
                          mensajeEntrada.FechaActualizacion);        

        _gestorId.Resuelve<IUbicacionesActor>().ProcesaInsertar(nuevoUbicaciones);

        return new UbicacionesMS
               (nuevoUbicaciones.UbicacionID,
                nuevoUbicaciones.AlmacenID,
                nuevoUbicaciones.CodigoUbicacion,
                nuevoUbicaciones.TipoUbicacion,
                nuevoUbicaciones.CapacidadUbicacion,
                nuevoUbicaciones.Ocupado,
                nuevoUbicaciones.FechaCreacion,
                nuevoUbicaciones.FechaActualizacion);
    }
    public UbicacionesMS EliminarUbicaciones(UbicacionesME mensajeEntrada)
    {
        var ubicacionesActor = _gestorId.Resuelve<IUbicacionesActor>();
        var ubicaciones = _gestorId.Resuelve<IUbicacionesActor>().ObtenerUbicacionesPorId(mensajeEntrada.UbicacionID);

        ubicacionesActor.ProcesaEliminar(ubicaciones);

        return new UbicacionesMS();
    }
}
