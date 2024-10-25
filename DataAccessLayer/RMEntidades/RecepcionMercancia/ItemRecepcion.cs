﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecepcionMercancia.Entidad;

[Table("ItemsRecepcion", Schema = "RecepcionMercancia")]
public class ItemRecepcion
{
    [Key]
    [Column("recepccionItemID")]
    public Guid RecepccionItemID { get; set; }  // Clave primaria

    [Column("recepcionID")]
    [Required]
    public Guid RecepcionID { get; set; }  // Clave foránea que referencia a Recepción

    [Column("productoID")]
    [Required]
    public Guid ProductoID { get; set; }  // Clave foránea que referencia a Producto

    [Column("cantidadRecibida")]
    [Required]
    public int CantidadRecibida { get; set; }  // Cantidad de producto recibido

    [Column("condicion")]
    [StringLength(50)]
    public string Condicion { get; set; }  // Condición del producto

    [Column("comentarios")]
    public string Comentarios { get; set; }  // Comentarios adicionales
    public ItemRecepcion()   {  }

    public ItemRecepcion(Guid recepccionItemID, Guid recepcionID, Guid productoID, int cantidadRecibida, string condicion, string comentarios)
    {
        RecepccionItemID = recepccionItemID;
        RecepcionID = recepcionID;
        ProductoID = productoID;
        CantidadRecibida = cantidadRecibida;
        Condicion = condicion;
        Comentarios = comentarios;
    }

    // Constructor solo con propiedades mapeadas


}