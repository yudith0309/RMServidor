using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionPedidos.Entidad;

[Table("Cliente", Schema = "GestionPedidos")]

public class Cliente
{
    [Key]
    [Column("ClienteID")]
    public int ClienteID { get; set; }  // Clave primaria del cliente

    [Column("Nombre")]
    [Required]
    [StringLength(100)]
    public string Nombre { get; set; }  // Nombre del cliente

    [Column("CorreoElectronico")]
    [Required]
    [StringLength(100)]
    public string CorreoElectronico { get; set; }  // Correo electrónico del cliente

    [Column("Telefono")]
    [StringLength(20)]
    public string Telefono { get; set; }  // Teléfono de contacto del cliente

    [Column("Direccion")]
    [StringLength(255)]
    public string Direccion { get; set; }  // Dirección de envío del cliente

    [Column("FechaCreacion")]
    public DateTime FechaCreacion { get; set; }  // Fecha de creación del cliente

    [Column("FechaActualizacion")]
    public DateTime FechaActualizacion { get; set; }  // Fecha de la última actualización de los datos del cliente
}