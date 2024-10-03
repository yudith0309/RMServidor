using AccesDataBase.Repository;
using GestionDevoluciones.Entidad;
using GestionDevoluciones.Interfaces;
using Utilidades;

namespace GestionDevoluciones;

public partial class PagosDevolucionesActor: IPagosDevolucionesActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public PagosDevolucionesActor(IRepository pagosDevolucionesRepository, IGestorId gestorId)
    {
        _repository = pagosDevolucionesRepository;
        _gestorId = gestorId;
    }
    public PagosDevoluciones ObtenerPagosDevolucionesPorId(Guid id)
    {
        return _repository.ObtenerPorId<PagosDevoluciones>(id);
    }

    public List<PagosDevoluciones> ObtenerListaPagosDevoluciones()
    {
        var listaPagosDevoluciones = _repository.ObtenerTodos<PagosDevoluciones>();
        return listaPagosDevoluciones;
    }
}
