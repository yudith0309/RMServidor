using RMMensajeria.GestionDevoluciones;

namespace GestionDevoluciones.Command.Interfaces;

public interface IDetallesDevolucionCmd
{
    DetallesDevolucionMS NuevoDetallesDevolucion(DetallesDevolucionME mensajeEntrada);
    DetallesDevolucionMS EliminarDetallesDevolucion(DetallesDevolucionME mensajeEntrada);
}
