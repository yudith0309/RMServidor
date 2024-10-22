using RMMensajeria.RecepcionMercancia;

namespace RecepcionMercancia.Command.Interfaces;

public interface IRecepcionCmd
{
    RecepcionesMS NuevoRecepcion(RecepcionesME mensajeEntrada);
    RecepcionesMS EliminarRecepcion(RecepcionesME mensajeEntrada);
}
