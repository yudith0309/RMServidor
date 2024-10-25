using RMMensajeria.GestionDevoluciones;

namespace GestionDevoluciones.Command.Interfaces;

public interface IPagosDevolucionesCmd
{
    PagosDevolucionesMS NuevoPagosDevoluciones(PagosDevolucionesME mensajeEntrada);
    PagosDevolucionesMS EliminarPagosDevoluciones(PagosDevolucionesME mensajeEntrada);
}
