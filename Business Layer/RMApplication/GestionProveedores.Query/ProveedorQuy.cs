using GestionProveedores.Interfaces;
using GestionProveedores.Query.interfaces;
using RMMensajeria.GestionProveedores;
using Utilidades;

namespace GestionProveedores.Query;

public class ProveedorQuy: IProveedorQuy
{
    private readonly IGestorId _gestorId;
    public ProveedorQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public ProveedorMS DevuelveProveedor(ProveedorME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IProveedorActor>().ObtenerProveedorPorId(mensajeEntrada.ProveedorID);
        return new ProveedorMS
        {
            ProveedorID = salida.ProveedorID,
            NombreProveedor = salida.NombreProveedor,
            InformacionContacto = salida.InformacionContacto,
            Direccion = salida.Direccion,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };


    }

    public ProveedorMSLista DevuelveTodosProveedores(ProveedorME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IProveedorActor>().ObtenerListaProveedor();
        var listaMS =
            lista.Transformar(proveedor =>
            new ProveedorMS(proveedor.ProveedorID,
                              proveedor.NombreProveedor,
                              proveedor.InformacionContacto,
                              proveedor.Direccion,
                              proveedor.FechaCreacion,
                              proveedor.FechaActualizacion));
        return new ProveedorMSLista(listaMS.ToArray());

    }
}
