﻿using RMMensajeria.GestionAlmacenes;

namespace GestionAlmacenes.Query.Interfaces;

public interface IOrdenesTransferenciaInternaQuy
{
    OrdenesTransferenciaInternaMS DevuelveOrdenesTransferenciaInterna(OrdenesTransferenciaInternaME mensajeEntrada);
    OrdenesTransferenciaInternaMSLista DevuelveTodosOrdenesTransferenciaInternaes(OrdenesTransferenciaInternaME mensajeEntrada);
}
