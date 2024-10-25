using RMMensajeria.GestionDevoluciones;

namespace GestionDevoluciones.Query.Interfaces;

public interface IDetallesDevolucionQuy
{
    DetallesDevolucionMS DevuelveDetallesDevolucion(DetallesDevolucionME mensajeEntrada);
    DetallesDevolucionMSLista DevuelveTodosDetallesDevoluciones(DetallesDevolucionME mensajeEntrada);
}
