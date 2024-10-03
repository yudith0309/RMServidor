using RecepcionMercancia.Entidad;
using RecepcionMercancia.Interfaces;

namespace RecepcionMercancia;

public partial class ProductoActor
{
    public void ProcesaInsertar(Producto producto)
    {
        _repository.Agregar(producto);

    }
    public Producto ProcesaActualizar(Guid producto, string codigo, string nombre, string descripcion, string um, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        var nuevo = _repository.ObtenerPorId<Producto>(producto);
        nuevo.CodigoProducto = codigo;
        nuevo.NombreProducto = nombre;
        nuevo.UnidadMedida = um;
        nuevo.FechaCreacion = fechaCreacion;
        nuevo.FechaActualizacion = fechaActualizacion;

        _gestorId.Resuelve<IProductoActor>().ProcesaInsertar(nuevo);

        return nuevo;
    }

    public void ProcesaEliminar(Producto producto)
    {
        _repository.Eliminar(producto);
    }
}
