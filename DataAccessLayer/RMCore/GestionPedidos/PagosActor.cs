using AccesDataBase.Repository;
using GestionPedidos.Entidad;
using GestionPedidos.Interfaces;
using Utilidades;

namespace GestionPedidos;

public partial class PagosActor: IPagosActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public PagosActor(IRepository pagosRepository, IGestorId gestorId)
    {
        _repository = pagosRepository;
        _gestorId = gestorId;
    }
    public Pagos ObtenerPagosPorId(Guid id)
    {
        return _repository.ObtenerPorId<Pagos>(id);
    }

    public List<Pagos> ObtenerListaPagos()
    {
        var listaPagos = _repository.ObtenerTodos<Pagos>();
        return listaPagos;
    }
}
