using GestionAlmacenes.Command.Interfaces;
using GestionAlmacenes.Entidad;
using GestionAlmacenes.Interfaces;
using RMMensajeria.GestionAlmacenes;
using Utilidades;

namespace GestionMovimientosAlmacen.Command;

public class MovimientosAlmacenCmd: IMovimientosAlmacenCmd
{
    private readonly IGestorId _gestorId;
    public MovimientosAlmacenCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public MovimientosAlmacenMS NuevoMovimientosAlmacen(MovimientosAlmacenME mensajeEntrada)
    {
        var nuevoMovimientosAlmacen =
            new MovimientosAlmacen(mensajeEntrada.MovimientoID,
                                   mensajeEntrada.ProductoID,
                                   mensajeEntrada.UbicacionOrigenID,
                                   mensajeEntrada.UbicacionDestinoID,
                                   mensajeEntrada.TipoMovimiento,
                                   mensajeEntrada.CantidadMovida,
                                   mensajeEntrada.FechaMovimiento,
                                   mensajeEntrada.DocumentoRelacionado,
                                   mensajeEntrada.UsuarioResponsable);
        
        _gestorId.Resuelve<IMovimientosAlmacenActor>().ProcesaInsertar(nuevoMovimientosAlmacen);

        return new MovimientosAlmacenMS
               (nuevoMovimientosAlmacen.MovimientoID,
                nuevoMovimientosAlmacen.ProductoID,
                nuevoMovimientosAlmacen.UbicacionOrigenID,
                nuevoMovimientosAlmacen.UbicacionDestinoID,
                nuevoMovimientosAlmacen.TipoMovimiento,
                nuevoMovimientosAlmacen.CantidadMovida,
                nuevoMovimientosAlmacen.FechaMovimiento,
                nuevoMovimientosAlmacen.DocumentoRelacionado,
                nuevoMovimientosAlmacen.UsuarioResponsable);
    }
    public MovimientosAlmacenMS EliminarMovimientosAlmacen(MovimientosAlmacenME mensajeEntrada)
    {
        var movimientosAlmacenActor = _gestorId.Resuelve<IMovimientosAlmacenActor>();
        var movimientosAlmacen = _gestorId.Resuelve<IMovimientosAlmacenActor>().ObtenerMovimientosAlmacenPorId(mensajeEntrada.MovimientoID);

        movimientosAlmacenActor.ProcesaEliminar(movimientosAlmacen);

        return new MovimientosAlmacenMS();
    }
}
