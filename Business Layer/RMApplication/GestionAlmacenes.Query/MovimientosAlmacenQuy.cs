using GestionAlmacenes.Interfaces;
using GestionAlmacenes.Query.Interfaces;
using RMMensajeria.GestionAlmacenes;
using Utilidades;

namespace GestionAlmacenes.Query;

public class MovimientosAlmacenQuy: IMovimientosAlmacenQuy
{
    private readonly IGestorId _gestorId;
    public MovimientosAlmacenQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public MovimientosAlmacenMS DevuelveMovimientosAlmacen(MovimientosAlmacenME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IMovimientosAlmacenActor>().ObtenerMovimientosAlmacenPorId(mensajeEntrada.MovimientoID);
        return new MovimientosAlmacenMS
        {
            MovimientoID = salida.MovimientoID,
            ProductoID = salida.ProductoID,
            UbicacionOrigenID = salida.UbicacionOrigenID,
            UbicacionDestinoID = salida.UbicacionDestinoID,
            TipoMovimiento = salida.TipoMovimiento,
            CantidadMovida = salida.CantidadMovida,
            FechaMovimiento = salida.FechaMovimiento,
            DocumentoRelacionado = salida.DocumentoRelacionado,
            UsuarioResponsable = salida.UsuarioResponsable
        };
    }
    public MovimientosAlmacenMSLista DevuelveTodosMovimientosAlmacenAlmacenes(AlmacenME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IMovimientosAlmacenActor>().ObtenerListaMovimientosAlmacen();
        var listaMS =
            lista.Transformar(almacenes =>
            new MovimientosAlmacenMS(almacenes.MovimientoID,
                                     almacenes.ProductoID,
                                     almacenes.UbicacionOrigenID,
                                     almacenes.UbicacionDestinoID,
                                     almacenes.TipoMovimiento,
                                     almacenes.CantidadMovida,
                                     almacenes.FechaMovimiento,
                                     almacenes.DocumentoRelacionado,
                                     almacenes.UsuarioResponsable));
        return new MovimientosAlmacenMSLista(listaMS.ToArray());
    }
}
