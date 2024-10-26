using GestionCompras.Interfaces;
using GestionCompras.Query.Interfaces;
using RMMensajeria.GestionCompras;
using Utilidades;

namespace GestionCompras.Query;

public class OrdenesCompraQuy : IOrdenesCompraQuy
{
    private readonly IGestorId _gestorId;
    public OrdenesCompraQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public OrdenesCompraMS DevuelveOrdenesCompra(OrdenesCompraME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IOrdenesCompraActor>().ObtenerOrdenesCompraPorId(mensajeEntrada.OrdenCompraID);
        return new OrdenesCompraMS
        {
            OrdenCompraID = salida.OrdenCompraID,
            ProveedorID = salida.ProveedorID,
            FechaOrden = salida.FechaOrden,
            FechaEntregaEstimada = salida.FechaEntregaEstimada,
            Total = salida.Total,
            Estado = salida.Estado,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };
    }
    public OrdenesCompraMSLista DevuelveTodosOrdenesCompraes(OrdenesCompraME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IOrdenesCompraActor>().ObtenerListaOrdenesCompra();
        var listaMS =
            lista.Transformar(ordenesCompra =>
            new OrdenesCompraMS(ordenesCompra.OrdenCompraID,
                                ordenesCompra.ProveedorID,
                                ordenesCompra.FechaOrden,
                                ordenesCompra.FechaEntregaEstimada,
                                ordenesCompra.Total,
                                ordenesCompra.Estado,
                                ordenesCompra.FechaCreacion,
                                ordenesCompra.FechaActualizacion));
        return new OrdenesCompraMSLista(listaMS.ToArray());
    }
}
