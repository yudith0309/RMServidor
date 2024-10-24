using RMMensajeria.GestionProveedores;

namespace GestionProveedores.Query.interfaces;

public interface IProveedorQuy
{
    ProveedorMS DevuelveProveedor(ProveedorME mensajeEntrada);
    ProveedorMSLista DevuelveTodosProveedores(ProveedorME mensajeEntrada);
}
