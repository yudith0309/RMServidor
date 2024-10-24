using RMMensajeria.TransporteEnvios;
using TransporteEnvios.Command.Interfaces;
using TransporteEnvios.Entidad;
using TransporteEnvios.Interfaces;
using Utilidades;

namespace TransporteEnvios.Command;

public class OrdenesEnvioCmd : IOrdenesEnvioCmd
{
    private readonly IGestorId _gestorId;
    public OrdenesEnvioCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public OrdenesEnvioMS NuevoOrdenesEnvio(OrdenesEnvioME mensajeEntrada)
    {

        var nuevoOrden =
            new OrdenesEnvio(mensajeEntrada.OrdenEnvioID,
                             mensajeEntrada.PedidoID,
                             mensajeEntrada.TransportistaID,
                             mensajeEntrada.FechaCreacion,
                             mensajeEntrada.Estado,
                             mensajeEntrada.FechaEnvio,
                             mensajeEntrada.FechaEntregaEstimada,
                             mensajeEntrada.CostoEnvio,
                             mensajeEntrada.FechaActualizacion);

        _gestorId.Resuelve<IOrdenesEnvioActor>().ProcesaInsertar(nuevoOrden);

        return new OrdenesEnvioMS
               (nuevoOrden.OrdenEnvioID,
                nuevoOrden.PedidoID,
                nuevoOrden.TransportistaID,
                nuevoOrden.FechaCreacion,
                nuevoOrden.Estado,
                nuevoOrden.FechaEnvio,
                nuevoOrden.FechaEntregaEstimada,
                nuevoOrden.CostoEnvio,
                nuevoOrden.FechaCreacion);
    }

    public OrdenesEnvioMS EliminarOrdenesEnvio(OrdenesEnvioME mensajeEntrada)
    {
        var ordenesEnvioActor = _gestorId.Resuelve<IOrdenesEnvioActor>();
        var ordenesEnvio = _gestorId.Resuelve<IOrdenesEnvioActor>().ObtenerOrdenesEnvioPorId(mensajeEntrada.OrdenEnvioID);

        ordenesEnvioActor.ProcesaEliminar(ordenesEnvio);

        return new OrdenesEnvioMS();
    }
}
