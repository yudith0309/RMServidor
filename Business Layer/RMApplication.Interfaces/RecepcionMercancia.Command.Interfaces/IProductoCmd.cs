﻿using RMMensajeria;

namespace ServiciosCmd.Interfaces;

public interface IProductoCmd
{
    ProductoMS NuevoProducto(ProductoME mensajeEntrada);
    ProductoMS ActualizaProducto(ProductoME mensajeEntrada);
}