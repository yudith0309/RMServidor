﻿namespace RMMensajeria.GestionPedidos;

public class ClienteMS
{
    public Guid ClienteID { get; set; }
    public string Nombre { get; set; }
    public string CorreoElectronico { get; set; }
    public string Telefono { get; set; }
    public string Direccion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaActualizacion { get; set; }

    public ClienteMS(Guid clienteID, string nombre, string correoElectronico, string telefono, string direccion, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        ClienteID = clienteID;
        Nombre = nombre;
        CorreoElectronico = correoElectronico;
        Telefono = telefono;
        Direccion = direccion;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public ClienteMS()
    {
    }
}

public class ClienteMSLista
{
    public ClienteMSLista() { }

    public ClienteMSLista(ClienteMS[] clienteMS)
    {
        ClienteMS = clienteMS;
    }
    public ClienteMS[] ClienteMS { get; set; }
}
