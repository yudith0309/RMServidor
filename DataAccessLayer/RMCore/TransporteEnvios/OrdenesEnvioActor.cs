using AccesDataBase.Repository;
using TransporteEnvios.Entidad;
using TransporteEnvios.Interfaces;
using Utilidades;

namespace TransporteEnvios;

public partial class OrdenesEnvioActor: IOrdenesEnvioActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public OrdenesEnvioActor(IRepository ordenesEnvioRepository, IGestorId gestorId)
    {
        _repository = ordenesEnvioRepository;
        _gestorId = gestorId;
    }
    public OrdenesEnvio ObtenerOrdenesEnvioPorId(Guid id)
    {
        return _repository.ObtenerPorId<OrdenesEnvio>(id);
    }

    public List<OrdenesEnvio> ObtenerListaOrdenesEnvio()
    {
        var listaOrdenesEnvio = _repository.ObtenerTodos<OrdenesEnvio>();
        return listaOrdenesEnvio;
    }
}
