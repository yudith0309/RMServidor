using GestionInventarios.Interfaces;
using GestionInventarios.Query.Interfaces;
using RMMensajeria.GestionInventarios;
using Utilidades;

namespace GestionInventarios.Query;

public class InventariosQuy : IInventariosQuy
{
    private readonly IGestorId _gestorId;
    public InventariosQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public InventariosMS DevuelveInventarios(InventariosME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IInventarioActor>().ObtenerInventarioPorId(mensajeEntrada.InventarioID);
        return new InventariosMS
        {
            InventarioID = salida.InventarioID,
            AlmacenID = salida.AlmacenID,
            ProductoID = salida.ProductoID,
            CantidadDisponible = salida.CantidadDisponible,
            FechaUltimaActualizacion = salida.FechaUltimaActualizacion
        };
    }

    public InventariosMSLista DevuelveTodosInventarioses(InventariosME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IInventarioActor>().ObtenerListaInventario();
        var listaMS =
            lista.Transformar(inventarios =>
            new InventariosMS(inventarios.InventarioID,
                              inventarios.AlmacenID,
                              inventarios.ProductoID,
                              inventarios.CantidadDisponible,
                              inventarios.FechaUltimaActualizacion));
        return new InventariosMSLista(listaMS.ToArray());
    }
}
