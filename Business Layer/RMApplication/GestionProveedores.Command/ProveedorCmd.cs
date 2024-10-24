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
        var proveedorActor = _gestorId.Resuelve<IProveedorActor>();
        var proveedor = _gestorId.Resuelve<IProveedorActor>().ObtenerProveedorPorId(mensajeEntrada.ProveedorID);

        proveedorActor.ProcesaEliminar(proveedor);

        return new ProveedorMS();
    }
}
