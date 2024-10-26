using RMMensajeria.GestionAlmacenes;

namespace GestionAlmacenes.Command.Interfaces;

public interface IUbicacionesCmd
{
    UbicacionesMS NuevoUbicaciones(UbicacionesME mensajeEntrada);
    UbicacionesMS EliminarUbicaciones(UbicacionesME mensajeEntrada);
}
