using RecepcionMercancia;
using RecepcionMercancia.Query.Interfaces;
using RMMensajeria;
using Utilidades;


namespace Servicios.RecepcionMercancia;

public class ProductoQuy: IProductoQuy
{
    private readonly IGestorId _gestorId;
    public ProductoQuy(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }
}
