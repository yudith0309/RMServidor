using GestionInventarios.Interfaces;
using GestionInventarios.Query.Interfaces;
using RMMensajeria.GestionInventarios;
using RMMensajeria.GestionInventarioUbicaciones;
using Utilidades;

namespace GestionInventarios.Query;

public class InventarioUbicacionesQuy : IInventarioUbicacionesQuy
{
    private readonly IGestorId _gestorId;
    public InventarioUbicacionesQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public InventarioUbicacionesMS DevuelveInventarioUbicaciones(InventarioUbicacionesME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IInventarioUbicacionesActor>().ObtenerInventarioUbicacionesPorId(mensajeEntrada.InventarioUbicacionID);
        return new InventarioUbicacionesMS
        {

            InventarioUbicacionID = salida.InventarioUbicacionID,
            UbicacionID = salida.UbicacionID,
            ProductoID = salida.ProductoID,
            CantidadDisponible = salida.CantidadDisponible,
            CantidadReservada = salida.CantidadReservada,
            FechaUltimaActualizacion = salida.FechaUltimaActualizacion
        };
    }

    public InventarioUbicacionesMSLista DevuelveTodosInventarioUbicacioneses(InventarioUbicacionesME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IInventarioUbicacionesActor>().ObtenerListaInventarioUbicaciones();
        var listaMS =
            lista.Transformar(inventarioUbicaciones =>
            new InventarioUbicacionesMS(inventarioUbicaciones.InventarioUbicacionID,
                                        inventarioUbicaciones.UbicacionID,
                                        inventarioUbicaciones.ProductoID,
                                        inventarioUbicaciones.CantidadDisponible,
                                        inventarioUbicaciones.CantidadReservada,
                                        inventarioUbicaciones.FechaUltimaActualizacion));
        return new InventarioUbicacionesMSLista(listaMS.ToArray());

    }
}
