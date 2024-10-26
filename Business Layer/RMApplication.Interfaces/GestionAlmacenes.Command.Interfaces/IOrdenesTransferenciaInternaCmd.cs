using RMMensajeria.GestionAlmacenes;

namespace GestionAlmacenes.Command.Interfaces;

public interface IOrdenesTransferenciaInternaCmd
{
    OrdenesTransferenciaInternaMS NuevoOrdenesTransferenciaInterna(OrdenesTransferenciaInternaME mensajeEntrada);
    OrdenesTransferenciaInternaMS EliminarOrdenesTransferenciaInterna(OrdenesTransferenciaInternaME mensajeEntrada);
}
