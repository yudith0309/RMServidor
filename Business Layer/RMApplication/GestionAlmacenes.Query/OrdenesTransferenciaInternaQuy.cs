using GestionAlmacenes.Interfaces;
using GestionAlmacenes.Query.Interfaces;
using RMMensajeria.GestionAlmacenes;
using Utilidades;

namespace GestionAlmacenes.Query;

public class OrdenesTransferenciaInternaQuy: IOrdenesTransferenciaInternaQuy
{
    private readonly IGestorId _gestorId;
    public OrdenesTransferenciaInternaQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
    public OrdenesTransferenciaInternaMS DevuelveOrdenesTransferenciaInterna(OrdenesTransferenciaInternaME mensajeEntrada)
    {
        var salida = _gestorId.Resuelve<IOrdenesTransferenciaInternaActor>().ObtenerOrdenesTransferenciaPorId(mensajeEntrada.OrdenTransferenciaID);
        return new OrdenesTransferenciaInternaMS
        {
            OrdenTransferenciaID = salida.OrdenTransferenciaID,
            AlmacenOrigenID = salida.AlmacenOrigenID,
            AlmacenDestinoID = salida.AlmacenDestinoID,
            ProductoID = salida.ProductoID,
            CantidadTransferida = salida.CantidadTransferida,
            FechaTransferencia = salida.FechaTransferencia,
            EstadoTransferencia = salida.EstadoTransferencia,
            UsuarioResponsable = salida.UsuarioResponsable
        };        
    }
    public OrdenesTransferenciaInternaMSLista DevuelveTodosOrdenesTransferenciaInternaes(OrdenesTransferenciaInternaME mensajeEntrada)
    {
        var lista = _gestorId.Resuelve<IOrdenesTransferenciaInternaActor>().ObtenerListaOrdenesTransferencia();
        var listaMS =
            lista.Transformar(ordenesTransferenciaInterna =>
            new OrdenesTransferenciaInternaMS(ordenesTransferenciaInterna.OrdenTransferenciaID,
                          ordenesTransferenciaInterna.AlmacenOrigenID,
                          ordenesTransferenciaInterna.AlmacenDestinoID,
                          ordenesTransferenciaInterna.ProductoID,
                          ordenesTransferenciaInterna.CantidadTransferida,
                          ordenesTransferenciaInterna.FechaTransferencia,
                          ordenesTransferenciaInterna.EstadoTransferencia,
                          ordenesTransferenciaInterna.UsuarioResponsable));
        return new OrdenesTransferenciaInternaMSLista(listaMS.ToArray());
    }
}
