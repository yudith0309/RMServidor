using GestionInventarios.Command.Interfaces;
using GestionInventarios.Entidad;
using GestionInventarios.Interfaces;
using RMMensajeria.GestionInventarios;
using Utilidades;

namespace GestionInventarios.Command;

public class MovimientosInventarioCmd : IMovimientosInventarioCmd
{
    private readonly IGestorId _gestorId;
    public MovimientosInventarioCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public MovimientosInventarioMS NuevoMovimientosInventario(MovimientosInventarioME mensajeEntrada)
    {
        var nuevoMovimientosInventario =
            new MovimientoInventario(
                mensajeEntrada.MovimientoID,
                mensajeEntrada.ProductoID,
                mensajeEntrada.AlmacenID,
                mensajeEntrada.TipoMovimiento,
                mensajeEntrada.Cantidad,
                mensajeEntrada.FechaMovimiento,
                mensajeEntrada.DocumentoRelacionado,
                mensajeEntrada.CreadoPor);

        _gestorId.Resuelve<IMovimientosInventarioActor>().ProcesaInsertar(nuevoMovimientosInventario);

        return new MovimientosInventarioMS
               (nuevoMovimientosInventario.MovimientoID,
                nuevoMovimientosInventario.ProductoID,
                nuevoMovimientosInventario.AlmacenID,
                nuevoMovimientosInventario.TipoMovimiento,
                nuevoMovimientosInventario.Cantidad,
                nuevoMovimientosInventario.FechaMovimiento,
                nuevoMovimientosInventario.DocumentoRelacionado,
                nuevoMovimientosInventario.CreadoPor);
    }

    public MovimientosInventarioMS EliminarMovimientosInventario(MovimientosInventarioME mensajeEntrada)
    {
        var movimientosInventarioActor = _gestorId.Resuelve<IMovimientosInventarioActor>();
        var movimientosInventario = _gestorId.Resuelve<IMovimientosInventarioActor>().ObtenerMovimientosInventarioPorId(mensajeEntrada.MovimientoID);

        movimientosInventarioActor.ProcesaEliminar(movimientosInventario);

        return new MovimientosInventarioMS();
    }
}
