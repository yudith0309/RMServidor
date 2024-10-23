using RMMensajeria.TransporteEnvios;
using TransporteEnvios.Interfaces;
using TransporteEnvios.Query.Interfaces;
using Utilidades;

namespace TransporteEnvios.Query;

public class OrdenesEnvioQuy: IOrdenesEnvioQuy
{
    private readonly IGestorId _gestorId;

    public OrdenesEnvioQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public OrdenesEnvioMS DevuelveOrdenesEnvio(OrdenesEnvioME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IOrdenesEnvioActor>().ObtenerOrdenesEnvioPorId(mensajeEntrada.OrdenEnvioID);
        return new OrdenesEnvioMS
        {
            OrdenEnvioID = salida.OrdenEnvioID,
            PedidoID = salida.PedidoID,
            TransportistaID = salida.TransportistaID,
            Estado = salida.Estado,
            FechaEnvio = salida.FechaEnvio,
            FechaEntregaEstimada = salida.FechaEntregaEstimada,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };
    }

    public OrdenesEnvioMSLista DevuelveTodosOrdenesEnvio(OrdenesEnvioME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IOrdenesEnvioActor>().ObtenerListaOrdenesEnvio();
        var listaMS =
            lista.Transformar(ordenesEnvio =>
            new OrdenesEnvioMS(ordenesEnvio.OrdenEnvioID,
                               ordenesEnvio.PedidoID,
                               ordenesEnvio.TransportistaID,
                               ordenesEnvio.FechaCreacion,
                               ordenesEnvio.Estado,
                               ordenesEnvio.FechaEnvio,
                               ordenesEnvio.FechaEntregaEstimada,
                               ordenesEnvio.CostoEnvio,
                               ordenesEnvio.FechaActualizacion));
        return new OrdenesEnvioMSLista(listaMS.ToArray());

    }
}
