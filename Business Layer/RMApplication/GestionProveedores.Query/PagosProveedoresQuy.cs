using GestionProveedores.Interfaces;
using GestionProveedores.Query.interfaces;
using RMMensajeria.GestionProveedores;
using Utilidades;

namespace GestionProveedores.Query;

public class PagosProveedoresQuy: IPagosProveedoresQuy
{
    private readonly IGestorId _gestorId;
    public PagosProveedoresQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public PagosProveedoresMS DevuelvePagosProveedores(PagosProveedoresME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IPagosProveedoresActor>().ObtenerPagosProveedoresPorId(mensajeEntrada.PagoProveedorID);
        return new PagosProveedoresMS
        {
            PagoProveedorID = salida.PagoProveedorID,
            ProveedorID = salida.ProveedorID,
            Monto = salida.Monto,
            FechaPago = salida.FechaPago,
            MetodoPago = salida.MetodoPago,
            EstadoPago = salida.EstadoPago,
            FechaCreacion = salida.FechaPago,
            FechaActualizacion = salida.FechaActualizacion
        };
    }

    public PagosProveedoresMSLista DevuelveTodosPagosProveedoreses(PagosProveedoresME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IPagosProveedoresActor>().ObtenerListaPagosProveedores();
        var listaMS =
            lista.Transformar(pagosProveedores =>
            new PagosProveedoresMS(pagosProveedores.PagoProveedorID,
                                   pagosProveedores.ProveedorID,
                                   pagosProveedores.Monto,
                                   pagosProveedores.FechaPago,
                                   pagosProveedores.MetodoPago,
                                   pagosProveedores.EstadoPago,
                                   pagosProveedores.FechaCreacion,
                                   pagosProveedores.FechaActualizacion));
        return new PagosProveedoresMSLista(listaMS.ToArray());

    }
}
