using RMMensajeria.GestionDevoluciones;

namespace GestionDevoluciones.Query.Interfaces;

public interface IPagosDevolucionesQuy
{
    PagosDevolucionesMS DevuelvePagosDevoluciones(PagosDevolucionesME mensajeEntrada);
    PagosDevolucionesMSLista DevuelveTodosPagosDevolucioneses(PagosDevolucionesME mensajeEntrada);
}
