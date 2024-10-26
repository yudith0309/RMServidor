using GestionAlmacenes.Command.Interfaces;
using GestionAlmacenes.Entidad;
using GestionAlmacenes.Interfaces;
using RMMensajeria.GestionAlmacenes;
using Utilidades;

namespace GestionAlmacenes.Command;

public class ZonasAlmacenCmd : IZonasAlmacenCmd
{
    private readonly IGestorId _gestorId;
    public ZonasAlmacenCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public ZonasAlmacenMS NuevoZonasAlmacen(ZonasAlmacenME mensajeEntrada)
    {
        var nuevoZonasAlmacen =
            new ZonasAlmacen(mensajeEntrada.ZonaID,
                             mensajeEntrada.AlmacenID,
                             mensajeEntrada.NombreZona,
                             mensajeEntrada.TipoZona,
                             mensajeEntrada.CapacidadZona,
                             mensajeEntrada.FechaCreacion,
                             mensajeEntrada.FechaActualizacion);

        _gestorId.Resuelve<IZonasAlmacenActor>().ProcesaInsertar(nuevoZonasAlmacen);

        return new ZonasAlmacenMS
               (nuevoZonasAlmacen.ZonaID,
                nuevoZonasAlmacen.AlmacenID,
                nuevoZonasAlmacen.NombreZona,
                nuevoZonasAlmacen.TipoZona,
                nuevoZonasAlmacen.CapacidadZona,
                nuevoZonasAlmacen.FechaCreacion,
                nuevoZonasAlmacen.FechaActualizacion);
    }
    public ZonasAlmacenMS EliminarZonasAlmacen(ZonasAlmacenME mensajeEntrada)
    {
        var zonasAlmacenActor = _gestorId.Resuelve<IZonasAlmacenActor>();
        var zonasAlmacen = _gestorId.Resuelve<IZonasAlmacenActor>().ObtenerZonasAlmacenPorId(mensajeEntrada.ZonaID);

        zonasAlmacenActor.ProcesaEliminar(zonasAlmacen);

        return new ZonasAlmacenMS();
    }
}
