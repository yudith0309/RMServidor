using RMMensajeria.GestionCompras;

namespace GestionCompras.Command.Interfaces;

public interface IOrdenesCompraCmd
{
    OrdenesCompraMS NuevoOrdenesCompra(OrdenesCompraME mensajeEntrada);
    OrdenesCompraMS EliminarOrdenesCompra(OrdenesCompraME mensajeEntrada);
}
