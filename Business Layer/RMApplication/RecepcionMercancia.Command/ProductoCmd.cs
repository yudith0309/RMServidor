﻿using RecepcionMercancia.Command.Interfaces;
using RecepcionMercancia.Entidad;
using RecepcionMercancia.Interfaces;
using RMMensajeria;
using Utilidades;

namespace RecepcionMercancia.Command;

public class ProductoCmd : IProductoCmd
{
    private readonly IGestorId _gestorId;
    public ProductoCmd(IGestorId gestorId)
    {
        _gestorId = gestorId;
    }

    public ProductoMS NuevoProducto(ProductoME mensajeEntrada)
    {
        var nuevoProducto =
            new Producto(
                mensajeEntrada.ProductoID,
                mensajeEntrada.CodigoProducto,
                mensajeEntrada.NombreProducto,
                mensajeEntrada.Descripcion,
                mensajeEntrada.UnidadMedida,
                mensajeEntrada.FechaCreacion,
                mensajeEntrada.FechaActualizacion);

        _gestorId.Resuelve<IProductoActor>().ProcesaInsertar(nuevoProducto);

        return new ProductoMS
               (nuevoProducto.ProductoID,
                nuevoProducto.CodigoProducto,
                nuevoProducto.NombreProducto,
                nuevoProducto.Descripcion,
                nuevoProducto.UnidadMedida,
                nuevoProducto.FechaCreacion,
                nuevoProducto.FechaActualizacion);
    }   

    public ProductoMS EliminarProducto(ProductoME mensajeEntrada)
    {
        var productoActor = _gestorId.Resuelve<IProductoActor>();
        var producto = _gestorId.Resuelve<IProductoActor>().ObtenerProductoPorId(mensajeEntrada.ProductoID);
                
        productoActor.ProcesaEliminar(producto);

        return new ProductoMS();
    }

    public ProductoMS ActualizaProducto(ProductoME mensajeEntrada)
    {
        var nuevoProducto =
            _gestorId
            .Resuelve<IProductoActor>()
            .ProcesaActualizar(mensajeEntrada.ProductoID,
                               mensajeEntrada.CodigoProducto,
                               mensajeEntrada.NombreProducto,
                               mensajeEntrada.Descripcion,
                               mensajeEntrada.UnidadMedida,
                               mensajeEntrada.FechaCreacion,
                               mensajeEntrada.FechaActualizacion);

        return new ProductoMS(nuevoProducto.ProductoID,
                              nuevoProducto.CodigoProducto,
                              nuevoProducto.NombreProducto,
                              nuevoProducto.Descripcion,
                              nuevoProducto.UnidadMedida,
                              nuevoProducto.FechaCreacion,
                              nuevoProducto.FechaActualizacion);
    }


}
