namespace RecepcionMercancia.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using RecepcionMercancia.Command.Interfaces;
using RecepcionMercancia.Query.Interfaces;
using RMMensajeria;
using System.Net;

[ApiController]
[Route("[controller]/[action]")]
public class ProductoController : Controller
{
    private readonly IProductoQuy _servicio;
    private readonly IProductoCmd _servicioCmd;

    public ProductoController(IProductoQuy servicio, IProductoCmd servicioCmd)
    {
        _servicio = servicio;
        _servicioCmd = servicioCmd;
    }

    // Métodos Query
    [HttpPost(Name = "DevuelveProducto")]
    [ProducesResponseType(typeof(ProductoMS), (int)HttpStatusCode.OK)]
    public IActionResult DevuelveProducto([FromBody] ProductoME mensajeEntrada)
    {
        var respuesta = _servicio.DevuelveProducto(mensajeEntrada);
        return Ok(respuesta);
    }

    [HttpPost(Name = "DevuelveTodosProductos")]
    [ProducesResponseType(typeof(ProductosMSLista), (int)HttpStatusCode.OK)]
    public IActionResult DevuelveTodosProductos([FromBody] ProductoME mensajeEntrada)
    {
        var respuesta = _servicio.DevuelveTodosProductos(mensajeEntrada);
        return Ok(respuesta);
    }

    // Métodos Command
    [HttpPost(Name = "NuevoProducto")]
    [ProducesResponseType(typeof(ProductoMS), (int)HttpStatusCode.OK)]
    public IActionResult NuevoProducto([FromBody] ProductoME mensajeEntrada)
    {
        var respuesta = _servicioCmd.NuevoProducto(mensajeEntrada);
        return Ok(respuesta);
    }

    [HttpPost(Name = "ActualizaProducto")]
    [ProducesResponseType(typeof(ProductoMS), (int)HttpStatusCode.OK)]
    public IActionResult ActualizaProducto([FromBody] ProductoME mensajeEntrada)
    {
        var respuesta = _servicioCmd.ActualizaProducto(mensajeEntrada);
        return Ok(respuesta);
    }
}
