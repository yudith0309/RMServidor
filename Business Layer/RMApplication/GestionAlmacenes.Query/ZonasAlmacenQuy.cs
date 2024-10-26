using GestionAlmacenes.Interfaces;
using GestionAlmacenes.Query.Interfaces;
using RMMensajeria.GestionAlmacenes;
using Utilidades;

namespace GestionAlmacenes.Query;

public class ZonasAlmacenQuy: IZonasAlmacenQuy
{
    private readonly IGestorId _gestorId;
    public ZonasAlmacenQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public ZonasAlmacenMS DevuelveZonasAlmacen(ZonasAlmacenME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IZonasAlmacenActor>().ObtenerZonasAlmacenPorId(mensajeEntrada.ZonaID);
        return new ZonasAlmacenMS
        {
            ZonaID = salida.ZonaID,
            AlmacenID = salida.AlmacenID,
            NombreZona = salida.NombreZona,
            TipoZona = salida.TipoZona,
            CapacidadZona = salida.CapacidadZona,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };
    }
    public ZonasAlmacenMSLista DevuelveTodosZonasAlmacenAlmacenes(AlmacenME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IZonasAlmacenActor>().ObtenerListaZonasAlmacen();
        var listaMS =
            lista.Transformar(almacenes =>
            new ZonasAlmacenMS(almacenes.ZonaID,
                              almacenes.AlmacenID,
                              almacenes.NombreZona,
                              almacenes.TipoZona,
                              almacenes.CapacidadZona,
                              almacenes.FechaCreacion,
                              almacenes.FechaActualizacion));
        return new ZonasAlmacenMSLista(listaMS.ToArray());
    }
}
