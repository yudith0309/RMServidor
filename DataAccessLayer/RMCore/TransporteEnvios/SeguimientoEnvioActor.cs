using AccesDataBase.Repository;
using TransporteEnvios.Entidad;
using TransporteEnvios.Interfaces;
using Utilidades;

namespace TransporteEnvios;

public partial class SeguimientoEnvioActor: ISeguimientoEnvioActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public SeguimientoEnvioActor(IRepository seguimientoEnvioRepository, IGestorId gestorId)
    {
        _repository = seguimientoEnvioRepository;
        _gestorId = gestorId;
    }
    public SeguimientoEnvio ObtenerSeguimientoEnvioPorId(Guid id)
    {
        return _repository.ObtenerPorId<SeguimientoEnvio>(id);
    }

    public List<SeguimientoEnvio> ObtenerListaSeguimientoEnvio()
    {
        var listaSeguimientoEnvio = _repository.ObtenerTodos<SeguimientoEnvio>();
        return listaSeguimientoEnvio;
    }
}
