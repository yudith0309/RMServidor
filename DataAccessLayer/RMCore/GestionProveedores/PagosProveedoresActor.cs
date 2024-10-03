using AccesDataBase.Repository;
using GestionProveedores.Entidad;
using GestionProveedores.Interfaces;
using Utilidades;

namespace GestionProveedores;

public partial class PagosProveedoresActor: IPagosProveedoresActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public PagosProveedoresActor(IRepository pagosProveedoresRepository, IGestorId gestorId)
    {
        _repository = pagosProveedoresRepository;
        _gestorId = gestorId;
    }
    public PagosProveedores ObtenerPagosProveedoresPorId(Guid id)
    {
        return _repository.ObtenerPorId<PagosProveedores>(id);
    }

    public List<PagosProveedores> ObtenerListaPagosProveedores()
    {
        var listaPagosProveedores = _repository.ObtenerTodos<PagosProveedores>();
        return listaPagosProveedores;
    }
}
