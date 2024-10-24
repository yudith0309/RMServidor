using GestionProveedores.Command.Interfaces;
using GestionProveedores.Entidad;
using GestionProveedores.Interfaces;
using RMMensajeria.GestionProveedores;
using Utilidades;

namespace GestionProveedores.Command;

public class PagosProveedoresCmd: IPagosProveedoresCmd
{
    private readonly IGestorId _gestorId;
    public PagosProveedoresCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public PagosProveedoresMS NuevoPagosProveedor(PagosProveedoresME mensajeEntrada)
    {

        var nuevoPagosProveedor =
            new PagosProveedores(
                mensajeEntrada.PagoProveedorID,
                mensajeEntrada.ProveedorID,
                mensajeEntrada.Monto,
                mensajeEntrada.FechaPago,
                mensajeEntrada.MetodoPago,
                mensajeEntrada.EstadoPago,
                mensajeEntrada.FechaCreacion,
                mensajeEntrada.FechaActualizacion);      


        _gestorId.Resuelve<IPagosProveedoresActor>().ProcesaInsertar(nuevoPagosProveedor);

        return new PagosProveedoresMS
               (nuevoPagosProveedor.PagoProveedorID,
                nuevoPagosProveedor.ProveedorID,
                nuevoPagosProveedor.Monto,
                nuevoPagosProveedor.FechaPago,
                nuevoPagosProveedor.MetodoPago,
                nuevoPagosProveedor.EstadoPago,
                nuevoPagosProveedor.FechaCreacion,
                nuevoPagosProveedor.FechaActualizacion);
    }

    public PagosProveedoresMS EliminarPagosProveedor(PagosProveedoresME mensajeEntrada)
    {
        var PagosProveedorActor = _gestorId.Resuelve<IPagosProveedoresActor>();
        var PagosProveedor = _gestorId.Resuelve<IPagosProveedoresActor>().ObtenerPagosProveedoresPorId(mensajeEntrada.PagoProveedorID);

        PagosProveedorActor.ProcesaEliminar(PagosProveedor);

        return new PagosProveedoresMS();
    }
}
