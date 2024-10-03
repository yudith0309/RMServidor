using AccesDataBase.Repository;
using TransporteEnvios.Entidad;
using TransporteEnvios.Interfaces;
using Utilidades;

namespace TransporteEnvios;

public partial class RutaActor: IRutaActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public RutaActor(IRepository rutaRepository, IGestorId gestorId)
    {
        _repository = rutaRepository;
        _gestorId = gestorId;
    }
    public Ruta ObtenerRutaPorId(Guid id)
    {
        return _repository.ObtenerPorId<Ruta>(id);
    }

    public List<Ruta> ObtenerListaRuta()
    {
        var listaRuta = _repository.ObtenerTodos<Ruta>();
        return listaRuta;
    }
}
