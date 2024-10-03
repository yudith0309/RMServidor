using AccesDataBase.Repository;
using GestionAlmacenes.Entidad;
using GestionAlmacenes.Interfaces;
using Utilidades;

namespace GestionAlmacenes;

public partial class OrdenesTransferenciaInternaActor: IOrdenesTransferenciaInternaActor
{
    private readonly IRepository _repository;
    private readonly IGestorId _gestorId;

    public OrdenesTransferenciaInternaActor(IRepository ordenesTransferenciaRepository, IGestorId gestorId)
    {
        _repository = ordenesTransferenciaRepository;
        _gestorId = gestorId;
    }
    public OrdenesTransferenciaInterna ObtenerOrdenesTransferenciaPorId(Guid id)
    {
        return _repository.ObtenerPorId<OrdenesTransferenciaInterna>(id);
    }

    public List<OrdenesTransferenciaInterna> ObtenerListaOrdenesTransferencia()
    {
        var listaOrdenesTransferencia = _repository.ObtenerTodos<OrdenesTransferenciaInterna>();
        return listaOrdenesTransferencia;
    }
}
