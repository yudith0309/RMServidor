using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GestionProveedores.Entidad;

[Table("Proveedor", Schema = "GestionProveedores")]
public class Proveedor
{
    [Key]
    [Column("proveedor_id")]
    public Guid ProveedorID { get; set; }  // Clave primaria

    [Column("nombre_proveedor")]
    [Required]
    [StringLength(100)]
    public string NombreProveedor { get; set; }  // Nombre del proveedor

    [Column("informacion_contacto")]
    public string InformacionContacto { get; set; }  // Información de contacto

    [Column("direccion")]
    [StringLength(255)]
    public string Direccion { get; set; }  // Dirección del proveedor

    [Column("fecha_creacion")]
    public DateTime FechaCreacion { get; set; }  // Fecha de creación

    [Column("fecha_actualizacion")]
    public DateTime FechaActualizacion { get; set; }  // Fecha de actualización

    public Proveedor(Guid proveedorID, string nombreProveedor, string informacionContacto, string direccion, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        ProveedorID = proveedorID;
        NombreProveedor = nombreProveedor;
        InformacionContacto = informacionContacto;
        Direccion = direccion;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public Proveedor()
    {
    }
}


