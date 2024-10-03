using AccesDataBase.Repository;
using TransporteEnvios.Entidad;
using TransporteEnvios.Interfaces;
using Utilidades;

namespace TransporteEnvios;

public partial class CostosEnvioActor: ICostosEnvioActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public CostosEnvioActor(IRepository costosEnvioRepository, IGestorId gestorId)
    {
        _repository = costosEnvioRepository;
        _gestorId = gestorId;
    }
    public CostosEnvio ObtenerCostosEnvioPorId(Guid id)
    {
        return _repository.ObtenerPorId<CostosEnvio>(id);
    }

    public List<CostosEnvio> ObtenerListaCostosEnvio()
    {
        var listaCostosEnvio = _repository.ObtenerTodos<CostosEnvio>();
        return listaCostosEnvio;
    }
}
