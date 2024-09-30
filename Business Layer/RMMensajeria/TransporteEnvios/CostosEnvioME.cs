namespace RMMensajeria.TransporteEnvios;

public class CostosEnvioME
{
    public Guid CostoEnvioID { get; set; }
    public Guid OrdenEnvioID { get; set; }
    public decimal CostoBase { get; set; }
    public decimal CostoAdicional { get; set; } = 0;
    public decimal Descuento { get; set; } = 0;
    public decimal CostoTotal { get; set; }
    public DateTime FechaCreacion { get; set; } = DateTime.Now;
    public DateTime FechaActualizacion { get; set; } = DateTime.Now;

    public CostosEnvioME(Guid costoEnvioID, Guid ordenEnvioID, decimal costoBase, decimal costoAdicional, decimal descuento, decimal costoTotal, DateTime fechaCreacion, DateTime fechaActualizacion)
    {
        CostoEnvioID = costoEnvioID;
        OrdenEnvioID = ordenEnvioID;
        CostoBase = costoBase;
        CostoAdicional = costoAdicional;
        Descuento = descuento;
        CostoTotal = costoTotal;
        FechaCreacion = fechaCreacion;
        FechaActualizacion = fechaActualizacion;
    }
    public CostosEnvioME()
    {
    }
}
