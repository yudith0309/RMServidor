using RMMensajeria.GestionPedidos;

namespace GestionPedidos.Command.Interfaces;

public interface IPagosCmd
{
    PagosMS NuevoPagos(PagosME mensajeEntrada);
    PagosMS EliminarPagos(PagosME mensajeEntrada);
}
