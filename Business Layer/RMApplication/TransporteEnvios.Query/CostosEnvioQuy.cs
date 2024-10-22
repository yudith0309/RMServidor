using RMMensajeria.TransporteEnvios;
using TransporteEnvios.Interfaces;
using TransporteEnvios.Query.Interfaces;
using Utilidades;

namespace TransporteEnvios.Query;

public class CostosEnvioQuy: ICostosEnvioQuy
{
    private readonly IGestorId _gestorId;

    public CostosEnvioQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public CostosEnvioMS DevuelveCostosEnvio(CostosEnvioME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<ICostosEnvioActor>().ObtenerCostosEnvioPorId(mensajeEntrada.CostoEnvioID);
        return new CostosEnvioMS
        {
            CostoEnvioID = salida.CostoEnvioID,
            OrdenEnvioID = salida.OrdenEnvioID,
            CostoBase = salida.CostoBase,
            CostoAdicional = salida.CostoAdicional,
            Descuento = salida.Descuento,
            CostoTotal = salida.CostoTotal,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };
    }

    public CostosEnvioMSLista DevuelveTodosCostosEnvio(CostosEnvioME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<ICostosEnvioActor>().ObtenerListaCostosEnvio();
        var listaMS =
            lista.Transformar(costosEnvio =>
            new CostosEnvioMS(costosEnvio.CostoEnvioID,
                              costosEnvio.OrdenEnvioID,
                              costosEnvio.CostoBase,
                              costosEnvio.CostoAdicional,
                              costosEnvio.Descuento,
                              costosEnvio.CostoTotal,
                              costosEnvio.FechaActualizacion,
                              costosEnvio.FechaCreacion));
        return new CostosEnvioMSLista(listaMS.ToArray());

    }
}
