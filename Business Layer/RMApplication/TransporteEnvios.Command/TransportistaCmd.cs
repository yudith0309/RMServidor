using RMMensajeria.TransporteEnvios;
using TransporteEnvios.Command.Interfaces;
using TransporteEnvios.Entidad;
using TransporteEnvios.Interfaces;
using Utilidades;

namespace TransporteEnvios.Command;

public class TransportistaCmd: ITransportistaCmd
{
    private readonly IGestorId _gestorId;
    public TransportistaCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public TransportistasMS NuevoTransportistas(TransportistasME mensajeEntrada)
    {
        var nuevoEnvio =
            new Transportista(mensajeEntrada.TransportistaID,
                              mensajeEntrada.NombreTransportista,
                              mensajeEntrada.Telefono,
                              mensajeEntrada.Email,
                              mensajeEntrada.Direccion,
                              mensajeEntrada.TarifaBase,
                              mensajeEntrada.Estado,
                              mensajeEntrada.FechaCreacion,
                              mensajeEntrada.FechaActualizacion);

        _gestorId.Resuelve<ITransportistasActor>().ProcesaInsertar(nuevoEnvio);

        return new TransportistasMS
               (nuevoEnvio.TransportistaID,
                nuevoEnvio.NombreTransportista,
                nuevoEnvio.Telefono,
                nuevoEnvio.Email,
                nuevoEnvio.Direccion,
                nuevoEnvio.TarifaBase,
                nuevoEnvio.Estado,
                nuevoEnvio.FechaCreacion,
                nuevoEnvio.FechaActualizacion);
    }

    public TransportistasMS EliminarTransportistas(TransportistasME mensajeEntrada)
    {
        var transportistasActor = _gestorId.Resuelve<ITransportistasActor>();
        var transportistas = _gestorId.Resuelve<ITransportistasActor>().ObtenerTransportistasPorId(mensajeEntrada.TransportistaID);

        transportistasActor.ProcesaEliminar(transportistas);

        return new TransportistasMS();
    }
}
