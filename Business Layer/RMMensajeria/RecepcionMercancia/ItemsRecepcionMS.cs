﻿namespace RMMensajeria.RecepcionMercancia;

public class ItemsRecepcionMS
{
    public Guid RecepccionItemID { get; set; }
    public Guid RecepcionID { get; set; }
    public Guid ProductoID { get; set; }
    public int CantidadRecibida { get; set; }
    public string Condicion { get; set; }
    public string Comentarios { get; set; }
    public ItemsRecepcionMS()
    {
    }
    public ItemsRecepcionMS(Guid recepccionItemID, Guid recepcionID, Guid productoID, int cantidadRecibida, string condicion, string comentarios)
    {
        RecepccionItemID = recepccionItemID;
        RecepcionID = recepcionID;
        ProductoID = productoID;
        CantidadRecibida = cantidadRecibida;
        Condicion = condicion;
        Comentarios = comentarios;
    }

    public class ItemsRecepcionesMSLista
    {
        public ItemsRecepcionesMSLista() { }

        public ItemsRecepcionesMSLista(ItemsRecepcionMS[] itemsRecepcionesMS)
        {
            ItemsRecepcionMS = itemsRecepcionesMS;
        }
        public ItemsRecepcionMS[] ItemsRecepcionMS { get; set; }
    }

}
