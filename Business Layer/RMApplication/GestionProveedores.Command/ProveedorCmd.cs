using GestionProveedores.Command.Interfaces;
using GestionProveedores.Entidad;
using GestionProveedores.Interfaces;
using RMMensajeria.GestionProveedores;
using Utilidades;

namespace GestionProveedores.Command;

public class ProveedorCmd : IProveedorCmd
{
    private readonly IGestorId _gestorId;
    public ProveedorCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public ProveedorMS NuevoProveedor(ProveedorME mensajeEntrada)
    {

        var nuevoProveedor =
            new Proveedor(
                mensajeEntrada.ProveedorID,
                mensajeEntrada.NombreProveedor,
                mensajeEntrada.InformacionContacto,
                mensajeEntrada.Direccion,
                mensajeEntrada.FechaCreacion,
                mensajeEntrada.FechaActualizacion);


        _gestorId.Resuelve<IProveedorActor>().ProcesaInsertar(nuevoProveedor);

        return new ProveedorMS
               (nuevoProveedor.ProveedorID,
                nuevoProveedor.NombreProveedor,
                nuevoProveedor.InformacionContacto,
                nuevoProveedor.Direccion,
                nuevoProveedor.FechaCreacion,
                nuevoProveedor.FechaActualizacion);
    }

    public ProveedorMS EliminarProveedor(ProveedorME mensajeEntrada)
    {
        var ProveedorActor = _gestorId.Resuelve<IProveedorActor>();
        var Proveedor = _gestorId.Resuelve<IProveedorActor>().ObtenerProveedorPorId(mensajeEntrada.ProveedorID);

        ProveedorActor.ProcesaEliminar(Proveedor);

        return new ProveedorMS();
    }
}
