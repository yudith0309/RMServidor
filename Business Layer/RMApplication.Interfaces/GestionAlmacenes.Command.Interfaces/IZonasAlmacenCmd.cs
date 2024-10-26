using RMMensajeria.GestionAlmacenes;

namespace GestionAlmacenes.Command.Interfaces;

public interface IZonasAlmacenCmd
{
    ZonasAlmacenMS NuevoZonasAlmacen(ZonasAlmacenME mensajeEntrada);
    ZonasAlmacenMS EliminarZonasAlmacen(ZonasAlmacenME mensajeEntrada);
}
