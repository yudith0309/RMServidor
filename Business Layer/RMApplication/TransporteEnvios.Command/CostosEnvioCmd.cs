using RMMensajeria.TransporteEnvios;
using TransporteEnvios.Command.Interfaces;
using TransporteEnvios.Entidad;
using TransporteEnvios.Interfaces;
using Utilidades;

namespace TransporteEnvios.Command;

public class CostosEnvioCmd : ICostosEnvioCmd
{
    private readonly IGestorId _gestorId;
    public CostosEnvioCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public CostosEnvioMS NuevoCostosEnvio(CostosEnvioME mensajeEntrada)
    {

        var nuevoCosto =
            new CostosEnvio(
                mensajeEntrada.CostoEnvioID,
                mensajeEntrada.OrdenEnvioID,
                mensajeEntrada.CostoBase,
                mensajeEntrada.CostoAdicional,
                mensajeEntrada.Descuento,
                mensajeEntrada.CostoTotal,
                mensajeEntrada.FechaCreacion,
                mensajeEntrada.FechaActualizacion);

        _gestorId.Resuelve<ICostosEnvioActor>().ProcesaInsertar(nuevoCosto);

        return new CostosEnvioMS
               (nuevoCosto.CostoEnvioID,
                nuevoCosto.OrdenEnvioID,
                nuevoCosto.CostoBase,
                nuevoCosto.CostoAdicional,
                nuevoCosto.Descuento,
                nuevoCosto.CostoTotal,
                nuevoCosto.FechaCreacion,
                nuevoCosto.FechaCreacion);
    }
    public CostosEnvioMS EliminarCostosEnvio(CostosEnvioME mensajeEntrada)
    {
        var costosEnvioActor = _gestorId.Resuelve<ICostosEnvioActor>();
        var costosEnvio = _gestorId.Resuelve<ICostosEnvioActor>().ObtenerCostosEnvioPorId(mensajeEntrada.CostoEnvioID);

        costosEnvioActor.ProcesaEliminar(costosEnvio);

        return new CostosEnvioMS();
    }
}
