using AccesDataBase.Repository;
using TransporteEnvios.Entidad;
using TransporteEnvios.Interfaces;
using Utilidades;

namespace TransporteEnvios;

public partial class TransportistasActor: ITransportistasActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public TransportistasActor(IRepository transportistasRepository, IGestorId gestorId)
    {
        _repository = transportistasRepository;
        _gestorId = gestorId;
    }
    public Transportista ObtenerTransportistasPorId(Guid id)
    {
        return _repository.ObtenerPorId<Transportista>(id);
    }

    public List<Transportista> ObtenerListaTransportista()
    {
        var listaTransportistas = _repository.ObtenerTodos<Transportista>();
        return listaTransportistas;
    }
}
