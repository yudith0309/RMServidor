using GestionInventarios.Command.Interfaces;
using GestionInventarios.Entidad;
using GestionInventarios.Interfaces;
using RMMensajeria.GestionInventarios;
using Utilidades;

namespace GestionInventarios.Command;

public class InventariosCmd: IInventariosCmd
{
    private readonly IGestorId _gestorId;
    public InventariosCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public InventariosMS NuevoInventarios(InventariosME mensajeEntrada)
    {

        var nuevoInventarios =
            new Inventario(
                mensajeEntrada.InventarioID,
                mensajeEntrada.AlmacenID,
                mensajeEntrada.ProductoID,
                mensajeEntrada.CantidadDisponible,
                mensajeEntrada.FechaUltimaActualizacion);

        _gestorId.Resuelve<IInventarioActor>().ProcesaInsertar(nuevoInventarios);

        return new InventariosMS
               (nuevoInventarios.InventarioID,
                nuevoInventarios.AlmacenID,
                nuevoInventarios.ProductoID,
                nuevoInventarios.CantidadDisponible,
                nuevoInventarios.FechaUltimaActualizacion);
    }

    public InventariosMS EliminarInventarios(InventariosME mensajeEntrada)
    {
        var inventariosActor = _gestorId.Resuelve<IInventarioActor>();
        var inventarios = _gestorId.Resuelve<IInventarioActor>().ObtenerInventarioPorId(mensajeEntrada.InventarioID);

        inventariosActor.ProcesaEliminar(inventarios);

        return new InventariosMS();
    }
}
