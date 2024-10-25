using GestionDevoluciones.Command.Interfaces;
using GestionDevoluciones.Entidad;
using GestionDevoluciones.Interfaces;
using RMMensajeria.GestionDevoluciones;
using Utilidades;

namespace GestionDevoluciones.Command;

public class DevolucionesCmd : IDevolucionesCmd
{
    private readonly IGestorId _gestorId;
    public DevolucionesCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public DevolucionesMS NuevoDevoluciones(DevolucionesME mensajeEntrada)
    {
        var nuevoDevoluciones =
            new Devoluciones(
                mensajeEntrada.DevolucionID,
                mensajeEntrada.PedidoID,
                mensajeEntrada.FechaDevolucion,
                mensajeEntrada.Motivo,
                mensajeEntrada.EstadoDevolucion,
                mensajeEntrada.FechaCreacion,
                mensajeEntrada.FechaActualizacion);

        _gestorId.Resuelve<IDevolucionesActor>().ProcesaInsertar(nuevoDevoluciones);

        return new DevolucionesMS
               (nuevoDevoluciones.DevolucionID,
                nuevoDevoluciones.PedidoID,
                nuevoDevoluciones.FechaDevolucion,
                nuevoDevoluciones.Motivo,
                nuevoDevoluciones.EstadoDevolucion,
                nuevoDevoluciones.FechaCreacion,
                nuevoDevoluciones.FechaActualizacion);
    }
    public DevolucionesMS EliminarDevoluciones(DevolucionesME mensajeEntrada)
    {
        var devolucionesActor = _gestorId.Resuelve<IDevolucionesActor>();
        var devoluciones = _gestorId.Resuelve<IDevolucionesActor>().ObtenerDevolucionesPorId(mensajeEntrada.DevolucionID);

        devolucionesActor.ProcesaEliminar(devoluciones);

        return new DevolucionesMS();
    }
}
