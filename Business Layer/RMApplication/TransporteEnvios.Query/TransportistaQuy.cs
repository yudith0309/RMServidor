using RMMensajeria.TransporteEnvios;
using TransporteEnvios.Interfaces;
using TransporteEnvios.Query.Interfaces;
using Utilidades;

namespace TransporteEnvios.Query;

public class TransportistaQuy: ITransportistaQuy
{
    private readonly IGestorId _gestorId;

    public TransportistaQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public TransportistasMS DevuelveTransportista(TransportistasME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<ITransportistasActor>().ObtenerTransportistasPorId(mensajeEntrada.TransportistaID);
        return new TransportistasMS
        {

            TransportistaID = salida.TransportistaID,
            NombreTransportista = salida.NombreTransportista,
            Telefono = salida.Telefono,
            Email = salida.Email,
            Direccion = salida.Direccion,
            TarifaBase = salida.TarifaBase,
            Estado = salida.Estado,
            FechaCreacion = salida.FechaCreacion,
            FechaActualizacion = salida.FechaActualizacion
        };
    }

    public TransportistasMSLista DevuelveTodosTransportista(TransportistasME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<ITransportistasActor>().ObtenerListaTransportista();
        var listaMS =
            lista.Transformar(transportista =>
            new TransportistasMS(transportista.TransportistaID,
                        transportista.NombreTransportista,
                        transportista.Telefono,
                        transportista.Email,
                        transportista.Direccion,
                        transportista.TarifaBase,
                        transportista.Estado,
                        transportista.FechaCreacion,
                        transportista.FechaActualizacion));
        return new TransportistasMSLista(listaMS.ToArray());

    }
}
