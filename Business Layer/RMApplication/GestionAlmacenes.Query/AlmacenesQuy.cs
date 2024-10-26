using GestionAlmacenes.Interfaces;
using GestionAlmacenes.Query.Interfaces;
using RMMensajeria.GestionAlmacenes;
using Utilidades;

namespace GestionAlmacenes.Query;

public class AlmacenesQuy: IAlmacenesQuy
{
    private readonly IGestorId _gestorId;
    public AlmacenesQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public AlmacenMS DevuelveAlmacenes(AlmacenME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IAlmacenActor>().ObtenerAlmacenPorId(mensajeEntrada.AlmacenID);
        return new AlmacenMS
        {
            AlmacenID = salida.AlmacenID,
            NombreAlmacen = salida.NombreAlmacen,
            Ubicacion = salida.Ubicacion,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };
    }
    public AlmacenMSLista DevuelveTodosAlmaceneses(AlmacenME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IAlmacenActor>().ObtenerListaAlmacen();
        var listaMS =
            lista.Transformar(almacenes =>
            new AlmacenMS(almacenes.AlmacenID,
                          almacenes.NombreAlmacen,
                          almacenes.Ubicacion,
                          almacenes.FechaCreacion,
                          almacenes.FechaActualizacion));
        return new AlmacenMSLista(listaMS.ToArray());
    }
}
