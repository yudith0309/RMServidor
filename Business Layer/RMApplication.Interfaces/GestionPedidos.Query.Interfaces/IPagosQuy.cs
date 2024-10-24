using RMMensajeria.GestionPedidos;

namespace GestionPedidos.Query.Interfaces;

public interface IPagosQuy
{
    PagosMS DevuelvePagos(PagosME mensajeEntrada);
    PagosMSLista DevuelveTodosPagoses(PagosME mensajeEntrada);
}
