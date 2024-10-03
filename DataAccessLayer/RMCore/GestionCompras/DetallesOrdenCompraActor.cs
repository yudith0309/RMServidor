using AccesDataBase.Repository;
using GestionCompras.Entidad;
using GestionCompras.Interfaces;
using Utilidades;

namespace GestionCompras;

public partial class DetallesOrdenCompraActor: IDetallesOrdenCompraActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public DetallesOrdenCompraActor(IRepository detallesOrdenCompraRepository, IGestorId gestorId)
    {
        _repository = detallesOrdenCompraRepository;
        _gestorId = gestorId;
    }
    public DetallesOrdenCompra ObtenerDetallesOrdenCompraPorId(Guid id)
    {
        return _repository.ObtenerPorId<DetallesOrdenCompra>(id);
    }

    public List<DetallesOrdenCompra> ObtenerListaDetallesOrdenCompra()
    {
        var listaDetallesOrdenCompra = _repository.ObtenerTodos<DetallesOrdenCompra>();
        return listaDetallesOrdenCompra;
    }
}
