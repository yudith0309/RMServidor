using RMMensajeria.RecepcionMercancia;

namespace RecepcionMercancia.Command.Interfaces;

public interface IItemRecepcionCmd
{
    ItemsRecepcionMS NuevoItemRecepcion(ItemsRecepcionME mensajeEntrada);
    ItemsRecepcionMS EliminarItemRecepcion(ItemsRecepcionME mensajeEntrada);
}
