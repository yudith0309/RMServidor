using GestionInventarios.Interfaces;
using GestionInventarios.Query.Interfaces;
using RMMensajeria.GestionInventarios;
using Utilidades;

namespace GestionInventarios.Query;

public class MovimientosInventarioQuy: IMovimientosInventarioQuy
{
    private readonly IGestorId _gestorId;
    public MovimientosInventarioQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public MovimientosInventarioMS DevuelveMovimientosInventario(MovimientosInventarioME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IMovimientosInventarioActor>().ObtenerMovimientosInventarioPorId(mensajeEntrada.MovimientoID);
        return new MovimientosInventarioMS
        {
            MovimientoID = salida.MovimientoID,
            ProductoID = salida.ProductoID,
            AlmacenID = salida.AlmacenID,
            TipoMovimiento = salida.TipoMovimiento,
            Cantidad = salida.Cantidad,
            FechaMovimiento = salida.FechaMovimiento,
            DocumentoRelacionado = salida.DocumentoRelacionado,
            CreadoPor = salida.CreadoPor
        };
    }

    public MovimientosInventarioMSLista DevuelveTodosMovimientosInventarioes(MovimientosInventarioME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IMovimientosInventarioActor>().ObtenerListaMovimientoInventario();
        var listaMS =
            lista.Transformar(movimientosInventario =>
            new MovimientosInventarioMS(movimientosInventario.MovimientoID,
                                        movimientosInventario.ProductoID,
                                        movimientosInventario.AlmacenID,
                                        movimientosInventario.TipoMovimiento,
                                        movimientosInventario.Cantidad,
                                        movimientosInventario.FechaMovimiento,
                                        movimientosInventario.DocumentoRelacionado,
                                        movimientosInventario.CreadoPor));
        return new MovimientosInventarioMSLista(listaMS.ToArray());
    }
}
