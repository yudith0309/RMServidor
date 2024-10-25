using RMMensajeria.GestionDevoluciones;

namespace GestionDevoluciones.Query.Interfaces;

public interface IDevolucionesQuy
{
    DevolucionesMS DevuelveDevoluciones(DevolucionesME mensajeEntrada);
    DevolucionesMSLista DevuelveTodosDevolucioneses(DevolucionesME mensajeEntrada);
}
