using RMMensajeria.GestionAlmacenes;

namespace GestionAlmacenes.Query.Interfaces;

public interface IAlmacenesQuy
{
    AlmacenMS DevuelveAlmacenes(AlmacenME mensajeEntrada);
    AlmacenMSLista DevuelveTodosAlmaceneses(AlmacenME mensajeEntrada);
}
