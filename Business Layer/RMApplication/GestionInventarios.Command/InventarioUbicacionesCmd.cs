using GestionInventarios.Command.Interfaces;
using GestionInventarios.Entidad;
using GestionInventarios.Interfaces;
using RMMensajeria.GestionInventarios;
using RMMensajeria.GestionInventarioUbicaciones;
using Utilidades;

namespace GestionInventarios.Command;

public class InventarioUbicacionesCmd : IInventarioUbicacionesCmd
{
    private readonly IGestorId _gestorId;
    public InventarioUbicacionesCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public InventarioUbicacionesMS NuevoInventarioUbicaciones(InventarioUbicacionesME mensajeEntrada)
    {

        var nuevoInventarioUbicaciones =
            new InventarioUbicaciones(
                mensajeEntrada.InventarioUbicacionID,
                mensajeEntrada.UbicacionID,
                mensajeEntrada.ProductoID,
                mensajeEntrada.CantidadDisponible,
                mensajeEntrada.CantidadReservada,
                mensajeEntrada.FechaUltimaActualizacion);

        _gestorId.Resuelve<IInventarioUbicacionesActor>().ProcesaInsertar(nuevoInventarioUbicaciones);

        return new InventarioUbicacionesMS
               (nuevoInventarioUbicaciones.InventarioUbicacionID,
                nuevoInventarioUbicaciones.UbicacionID,
                nuevoInventarioUbicaciones.ProductoID,
                nuevoInventarioUbicaciones.CantidadDisponible,
                nuevoInventarioUbicaciones.CantidadReservada,
                nuevoInventarioUbicaciones.FechaUltimaActualizacion);
    }

    public InventarioUbicacionesMS EliminarInventarioUbicaciones(InventarioUbicacionesME mensajeEntrada)
    {
        var inventarioUbicacionesActor = _gestorId.Resuelve<IInventarioUbicacionesActor>();
        var inventarioUbicaciones = _gestorId.Resuelve<IInventarioUbicacionesActor>().ObtenerInventarioUbicacionesPorId(mensajeEntrada.InventarioUbicacionID);

        inventarioUbicacionesActor.ProcesaEliminar(inventarioUbicaciones);

        return new InventarioUbicacionesMS();
    }
}
