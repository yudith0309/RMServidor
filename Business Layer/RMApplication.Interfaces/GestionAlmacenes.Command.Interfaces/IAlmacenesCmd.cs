using RMMensajeria.GestionAlmacenes;

namespace GestionAlmacenes.Command.Interfaces;

public interface IAlmacenesCmd
{
    AlmacenMS NuevoAlmacen(AlmacenME mensajeEntrada);
    AlmacenMS EliminarAlmacen(AlmacenME mensajeEntrada);
}
