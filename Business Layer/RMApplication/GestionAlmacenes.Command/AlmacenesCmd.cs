using GestionAlmacenes.Command.Interfaces;
using GestionAlmacenes.Entidad;
using GestionAlmacenes.Interfaces;
using RMMensajeria.GestionAlmacenes;
using Utilidades;

namespace GestionAlmacenes.Command;

public class AlmacenesCmd: IAlmacenesCmd
{
    private readonly IGestorId _gestorId;
    public AlmacenesCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public AlmacenMS NuevoAlmacen(AlmacenME mensajeEntrada)
    {
        var nuevoAlmacen =
            new Almacen(mensajeEntrada.AlmacenID,
                        mensajeEntrada.NombreAlmacen,
                        mensajeEntrada.Ubicacion,
                        mensajeEntrada.FechaCreacion,
                        mensajeEntrada.FechaActualizacion);

        _gestorId.Resuelve<IAlmacenActor>().ProcesaInsertar(nuevoAlmacen);

        return new AlmacenMS
               (nuevoAlmacen.AlmacenID,
                nuevoAlmacen.NombreAlmacen,
                nuevoAlmacen.Ubicacion,
                nuevoAlmacen.FechaCreacion,
                nuevoAlmacen.FechaActualizacion);
    }
    public AlmacenMS EliminarAlmacen(AlmacenME mensajeEntrada)
    {
        var almacenActor = _gestorId.Resuelve<IAlmacenActor>();
        var almacen = _gestorId.Resuelve<IAlmacenActor>().ObtenerAlmacenPorId(mensajeEntrada.AlmacenID);

        almacenActor.ProcesaEliminar(almacen);

        return new AlmacenMS();
    }
}
