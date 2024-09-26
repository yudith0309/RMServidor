using Utilidades;

namespace RecepcionMercancia;

public partial class ProductoActor
{
    private readonly IGestorId _gestorId;
    public ProductoActor(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public void ProcesaInsertar(Producto producto)
    {
        _repository.Agregar(producto);

    }
    public Producto ProcesaActualizar(Guid producto, string codigo,string nombre,string descripcion,string um,DateTime fechaCreacion,DateTime fechaActualizacion)
    {
        var nuevo = 
            _repository
            .ObtenerPorId<Producto>(producto);
            nuevo.ProductoID = producto;
            nuevo.CodigoProducto = codigo;
            nuevo.NombreProducto = nombre;
            nuevo.UnidadMedida = um;
            nuevo.FechaCreacion = fechaCreacion;
            nuevo.FechaActualizacion = fechaActualizacion;

      _gestorId.Resuelve<IProductoActor>().ProcesaInsertar(nuevo);

        return nuevo;
    }
}
