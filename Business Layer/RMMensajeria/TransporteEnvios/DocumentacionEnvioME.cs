namespace RMMensajeria.TransporteEnvios;

public class DocumentacionEnvioME
{
    public Guid DocumentacionID { get; set; }
    public Guid OrdenEnvioID { get; set; }
    public string TipoDocumento { get; set; }
    public string RutaArchivo { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;

    public DocumentacionEnvioME(Guid documentacionID, Guid ordenEnvioID, string tipoDocumento, string rutaArchivo, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        DocumentacionID = documentacionID;
        OrdenEnvioID = ordenEnvioID;
        TipoDocumento = tipoDocumento;
        RutaArchivo = rutaArchivo;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public DocumentacionEnvioME()
    {
    }
}
