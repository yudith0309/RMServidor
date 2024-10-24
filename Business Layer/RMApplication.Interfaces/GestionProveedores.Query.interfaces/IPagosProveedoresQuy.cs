using RMMensajeria.GestionProveedores;

namespace GestionProveedores.Query.interfaces;

public interface IPagosProveedoresQuy
{
    PagosProveedoresMS DevuelvePagosProveedores(PagosProveedoresME mensajeEntrada);
    PagosProveedoresMSLista DevuelveTodosPagosProveedoreses(PagosProveedoresME mensajeEntrada);
}
