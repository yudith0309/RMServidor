﻿using RMMensajeria;

namespace RecepcionMercancia.Query.Interfaces;

public interface IProductoQuy
{
    ProductoMS DevuelveProducto(ProductoME mensajeEntrada);
    ProductosMSLista DevuelveTodosProductos(ProductoME mensajeEntrada);
}
