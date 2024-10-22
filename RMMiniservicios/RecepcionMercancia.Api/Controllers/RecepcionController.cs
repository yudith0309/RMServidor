using Microsoft.AspNetCore.Mvc;
using RecepcionMercancia.Command.Interfaces;
using RecepcionMercancia.Query.Interfaces;
using RMMensajeria.RecepcionMercancia;
using System.Net;

namespace RecepcionMercancia.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class RecepcionController : Controller
{
    private readonly IRecepcionQuy _servicio;
    private readonly IRecepcionCmd _servicioCmd;

    public RecepcionController(IRecepcionQuy servicio, IRecepcionCmd servicioCmd)
    {
        _servicio = servicio;
        _servicioCmd = servicioCmd;
    }

    // Métodos Query
    [HttpPost(Name = "DevuelveRecepcion")]
    [ProducesResponseType(typeof(RecepcionesMS), (int)HttpStatusCode.OK)]
    public IActionResult DevuelveRecepcion([FromBody] RecepcionesME mensajeEntrada)
    {
        var respuesta = _servicio.DevuelveRecepcion(mensajeEntrada);
        return Ok(respuesta);
    }

    [HttpPost(Name = "DevuelveTodosRecepciones")]
    [ProducesResponseType(typeof(RecepcionesMSLista), (int)HttpStatusCode.OK)]
    public IActionResult DevuelveTodosRecepciones([FromBody] RecepcionesME mensajeEntrada)
    {
        var respuesta = _servicio.DevuelveTodosRecepciones(mensajeEntrada);
        return Ok(respuesta);
    }

    // Métodos Command
    [HttpPost(Name = "NuevoRecepcion")]
    [ProducesResponseType(typeof(RecepcionesMS), (int)HttpStatusCode.OK)]
    public IActionResult NuevoRecepcion([FromBody] RecepcionesME mensajeEntrada)
    {
        var respuesta = _servicioCmd.NuevoRecepcion(mensajeEntrada);
        return Ok(respuesta);
    }

    [HttpPost(Name = "EliminarRecepcion")]
    [ProducesResponseType(typeof(RecepcionesMS), (int)HttpStatusCode.OK)]
    public IActionResult EliminarRecepcion([FromBody] RecepcionesME mensajeEntrada)
    {
        var respuesta = _servicioCmd.EliminarRecepcion(mensajeEntrada);
        return Ok(respuesta);
    }
}
