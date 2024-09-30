﻿namespace RMMensajeria.GestionDevoluciones;

public class DevolucionesME
{
    public Guid DevolucionID { get; set; }
    public Guid PedidoID { get; set; }
    public DateTime FechaDevolucion { get; set; }
    public string Motivo { get; set; }
    public string EstadoDevolucion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaActualizacion { get; set; }

    public DevolucionesME(Guid devolucionID, Guid pedidoID, DateTime fechaDevolucion, string motivo, string estadoDevolucion, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        DevolucionID = devolucionID;
        PedidoID = pedidoID;
        FechaDevolucion = fechaDevolucion;
        Motivo = motivo;
        EstadoDevolucion = estadoDevolucion;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public DevolucionesME()
    {
    }
}