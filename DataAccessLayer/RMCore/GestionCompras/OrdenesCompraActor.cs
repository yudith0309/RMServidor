using AccesDataBase.Repository;
using GestionCompras.Entidad;
using GestionCompras.Interfaces;
using Utilidades;

namespace GestionCompras;

public partial class OrdenesCompraActor: IOrdenesCompraActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;
    public OrdenesCompraActor(IRepository ordenesCompraRepository, IGestorId gestorId)
    {
        _repository = ordenesCompraRepository;
        _gestorId = gestorId;
    }
    public OrdenesCompra ObtenerOrdenesCompraPorId(Guid id)
    {
        return _repository.ObtenerPorId<OrdenesCompra>(id);
    }

    public List<OrdenesCompra> ObtenerListaOrdenesCompra()
    {
        var listaOrdenesCompra = _repository.ObtenerTodos<OrdenesCompra>();
        return listaOrdenesCompra;
    }
}
