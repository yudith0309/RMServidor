using GestionCompras.Command.Interfaces;
using GestionCompras.Entidad;
using GestionCompras.Interfaces;
using RMMensajeria.GestionCompras;
using Utilidades;

namespace GestionCompras.Command;

public class OrdenesCompraCmd: IOrdenesCompraCmd
{
    private readonly IGestorId _gestorId;
    public OrdenesCompraCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public OrdenesCompraMS NuevoOrdenesCompra(OrdenesCompraME mensajeEntrada)
    {
        var nuevoOrdenesCompra =
            new OrdenesCompra(
                mensajeEntrada.OrdenCompraID,
                mensajeEntrada.ProveedorID,
                mensajeEntrada.FechaOrden,
                mensajeEntrada.FechaEntregaEstimada,
                mensajeEntrada.Total,
                mensajeEntrada.Estado,
                mensajeEntrada.FechaCreacion,
                mensajeEntrada.FechaActualizacion);

        _gestorId.Resuelve<IOrdenesCompraActor>().ProcesaInsertar(nuevoOrdenesCompra);

        return new OrdenesCompraMS
               (nuevoOrdenesCompra.OrdenCompraID,
                nuevoOrdenesCompra.ProveedorID,
                nuevoOrdenesCompra.FechaOrden,
                nuevoOrdenesCompra.FechaEntregaEstimada,
                nuevoOrdenesCompra.Total,
                nuevoOrdenesCompra.Estado,
                nuevoOrdenesCompra.FechaCreacion,
                nuevoOrdenesCompra.FechaActualizacion);
    }
    public OrdenesCompraMS EliminarOrdenesCompra(OrdenesCompraME mensajeEntrada)
    {
        var ordenesCompraActor = _gestorId.Resuelve<IOrdenesCompraActor>();
        var ordenesCompra = _gestorId.Resuelve<IOrdenesCompraActor>().ObtenerOrdenesCompraPorId(mensajeEntrada.OrdenCompraID);

        ordenesCompraActor.ProcesaEliminar(ordenesCompra);

        return new OrdenesCompraMS();
    }
}
