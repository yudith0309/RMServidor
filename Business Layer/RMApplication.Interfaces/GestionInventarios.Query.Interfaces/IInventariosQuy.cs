using RMMensajeria.GestionInventarios;

namespace GestionInventarios.Query.Interfaces;

public interface IInventariosQuy
{
    InventariosMS DevuelveInventarios(InventariosME mensajeEntrada);
    InventariosMSLista DevuelveTodosInventarioses(InventariosME mensajeEntrada);
}
