using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TransporteEnvios.Entidad;

[Table("Transportistas", Schema = "Logistica")]
public class Transportista
{
    [Key]
    [Column("transportistaID")]
    public Guid TransportistaID { get; set; }  // Clave primaria del transportista

    [Column("nombreTransportista")]
    [Required]
    public string NombreTransportista { get; set; }  // Nombre del transportista

    [Column("telefono")]
    public string Telefono { get; set; }  // Número de teléfono del transportista

    [Column("email")]
    public string Email { get; set; }  // Correo electrónico del transportista

    [Column("direccion")]
    public string Direccion { get; set; }  // Dirección física del transportista

    [Column("tarifaBase")]
    [Required]
    public decimal TarifaBase { get; set; }  // Tarifa base por kilómetro o peso

    [Column("estado")]
    [Required]
    public string Estado { get; set; }  // Estado del transportista

    [Column("fechaCreacion")]
    public DateTime FechaCreacion { get; set; } = DateTime.Now;  // Fecha de creación del registro

    [Column("fechaActualizacion")]
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;  // Fecha de última actualización

    public Transportista(Guid transportistaID, string nombreTransportista, string telefono, string email, string direccion, decimal tarifaBase, string estado, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        TransportistaID = transportistaID;
        NombreTransportista = nombreTransportista;
        Telefono = telefono;
        Email = email;
        Direccion = direccion;
        TarifaBase = tarifaBase;
        Estado = estado;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public Transportista()
    {
    }
}