﻿namespace RMMensajeria.GestionProveedores;

public class ProveedorMS
{
    public Guid ProveedorID { get; set; }
    public string NombreProveedor { get; set; }
    public string InformacionContacto { get; set; }
    public string Direccion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaActualizacion { get; set; }

    public ProveedorMS(Guid proveedorID, string nombreProveedor, string informacionContacto, string direccion, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        ProveedorID = proveedorID;
        NombreProveedor = nombreProveedor;
        InformacionContacto = informacionContacto;
        Direccion = direccion;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public ProveedorMS()
    {
    }
}