namespace RMMensajeria.GestionProveedores;

public class HistorialProveedorME
{
    public Guid HistorialProveedorID { get; set; }
    public Guid ProveedorID { get; set; }
    public DateTime FechaEvaluacion { get; set; } = DateTime.Now;
    public int Calificacion { get; set; }
    public string Comentarios { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;

    public HistorialProveedorME(Guid historialProveedorID, Guid proveedorID, DateTime fechaEvaluacion, int calificacion, string comentarios, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        HistorialProveedorID = historialProveedorID;
        ProveedorID = proveedorID;
        FechaEvaluacion = fechaEvaluacion;
        Calificacion = calificacion;
        Comentarios = comentarios;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public HistorialProveedorME()
    {
    }
}
