using GestionAlmacenes.Interfaces;
using GestionAlmacenes.Query.Interfaces;
using RMMensajeria.GestionAlmacenes;
using Utilidades;

namespace GestionAlmacenes.Query;

public class UbicacionesQuy: IUbicacionesQuy
{
    private readonly IGestorId _gestorId;
    public UbicacionesQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public UbicacionesMS DevuelveUbicaciones(UbicacionesME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IUbicacionesActor>().ObtenerUbicacionesPorId(mensajeEntrada.UbicacionID);
        return new UbicacionesMS
        {
            UbicacionID = salida.UbicacionID,
            AlmacenID = salida.AlmacenID,
            CodigoUbicacion = salida.CodigoUbicacion,
            TipoUbicacion = salida.TipoUbicacion,
            CapacidadUbicacion = salida.CapacidadUbicacion,
            Ocupado = salida.Ocupado,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };
    }
    public UbicacionesMSLista DevuelveTodosUbicacionesAlmacenes(AlmacenME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IUbicacionesActor>().ObtenerListaUbicaciones();
        var listaMS =
            lista.Transformar(almacenes =>
            new UbicacionesMS(almacenes.UbicacionID,
                              almacenes.AlmacenID,
                              almacenes.CodigoUbicacion,
                              almacenes.TipoUbicacion,
                              almacenes.CapacidadUbicacion,
                              almacenes.Ocupado,
                              almacenes.FechaCreacion,
                              almacenes.FechaActualizacion));
        return new UbicacionesMSLista(listaMS.ToArray());
    }
}
