using AccesDataBase.Repository;
using GestionProveedores.Entidad;
using GestionProveedores.Interfaces;
using Utilidades;

namespace GestionProveedores;

public partial class ProveedorActor: IProveedorActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public ProveedorActor(IRepository proveedorRepository, IGestorId gestorId)
    {
        _repository = proveedorRepository;
        _gestorId = gestorId;
    }
    public Proveedor ObtenerProveedorPorId(Guid id)
    {
        return _repository.ObtenerPorId<Proveedor>(id);
    }

    public List<Proveedor> ObtenerListaProveedor()
    {
        var listaProveedor = _repository.ObtenerTodos<Proveedor>();
        return listaProveedor;
    }
}
