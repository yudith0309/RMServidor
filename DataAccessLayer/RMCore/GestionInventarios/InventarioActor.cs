using AccesDataBase.Repository;
using GestionInventarios.Entidad;
using GestionInventarios.Interfaces;
using Utilidades;

namespace GestionInventarios;

public partial class InventarioActor: IInventarioActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public InventarioActor(IRepository inventarioRepository, IGestorId gestorId)
    {
        _repository = inventarioRepository;
        _gestorId = gestorId;
    }
    public Inventario ObtenerInventarioPorId(Guid id)
    {
        return _repository.ObtenerPorId<Inventario>(id);
    }

    public List<Inventario> ObtenerListaInventario()
    {
        var listaInventario = _repository.ObtenerTodos<Inventario>();
        return listaInventario;
    }
}
