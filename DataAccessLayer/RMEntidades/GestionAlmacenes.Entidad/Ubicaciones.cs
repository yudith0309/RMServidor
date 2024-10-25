﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionAlmacenes.Entidad;

[Table("Ubicaciones", Schema = "GestionAlmacenes")]
public class Ubicacion
{
    [Key]
    [Column("ubicacionID")]
    public Guid UbicacionID { get; set; }  // Clave primaria de la ubicación dentro del almacén

    [Column("almacenID")]
    [Required]
    public Guid AlmacenID { get; set; }  // Clave foránea que referencia a la tabla Almacenes

    [Column("codigoUbicacion")]
    [Required]
    [StringLength(50)]
    public string CodigoUbicacion { get; set; }  // Código único que identifica la ubicación

    [Column("tipoUbicacion")]
    [Required]
    [StringLength(50)]
    public string TipoUbicacion { get; set; }  // Tipo de ubicación: picking, almacenamiento, zona de devoluciones

    [Column("capacidadUbicacion")]
    [Precision(18, 2)]
    public decimal CapacidadUbicacion { get; set; }  // Capacidad máxima de la ubicación

    [Column("ocupado")]
    public bool Ocupado { get; set; }  // Indica si la ubicación está ocupada

    [Column("fechaCreacion")]
    public DateTime FechaCreacion { get; set; }  // Fecha de creación de la ubicación

    [Column("fechaActualizacion")]
    public DateTime FechaActualizacion { get; set; }  // Fecha de la última actualización de la ubicación

    public Ubicacion()
    {
    }
    public Ubicacion(Guid ubicacionID, Guid almacenID, string codigoUbicacion, string tipoUbicacion, decimal capacidadUbicacion, bool ocupado, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        UbicacionID = ubicacionID;
        AlmacenID = almacenID;
        CodigoUbicacion = codigoUbicacion;
        TipoUbicacion = tipoUbicacion;
        CapacidadUbicacion = capacidadUbicacion;
        Ocupado = ocupado;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }


}
