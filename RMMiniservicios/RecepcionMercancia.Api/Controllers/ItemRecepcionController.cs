namespace RecepcionMercancia.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using RecepcionMercancia.Command.Interfaces;
using RecepcionMercancia.Query.Interfaces;
using RMMensajeria.RecepcionMercancia;
using System.Net;
using static RMMensajeria.RecepcionMercancia.ItemsRecepcionMS;

[ApiController]
[Route("[controller]/[action]")]
public class ItemsRecepcionController : Controller
{
    private readonly IItemRecepcionQuy _servicio;
    private readonly IItemRecepcionCmd _servicioCmd;

    public ItemsRecepcionController(IItemRecepcionQuy servicio, IItemRecepcionCmd servicioCmd)
    {
        _servicio = servicio;
        _servicioCmd = servicioCmd;
    }

    // Métodos Query
    [HttpPost(Name = "DevuelveItemRecepcion")]
    [ProducesResponseType(typeof(ItemsRecepcionMS), (int)HttpStatusCode.OK)]
    public IActionResult DevuelveItemRecepcion([FromBody] ItemsRecepcionME mensajeEntrada)
    {
        var respuesta = _servicio.DevuelveItemRecepcion(mensajeEntrada);
        return Ok(respuesta);
    }

    [HttpPost(Name = "DevuelveTodosItemRecepciones")]
    [ProducesResponseType(typeof(ItemsRecepcionesMSLista), (int)HttpStatusCode.OK)]
    public IActionResult DevuelveTodosItemRecepciones([FromBody] ItemsRecepcionME mensajeEntrada)
    {
        var respuesta = _servicio.DevuelveTodosItemRecepciones(mensajeEntrada);
        return Ok(respuesta);
    }

    // Métodos Command
    [HttpPost(Name = "NuevoItemRecepcion")]
    [ProducesResponseType(typeof(ItemsRecepcionMS), (int)HttpStatusCode.OK)]
    public IActionResult NuevoItemRecepcion([FromBody] ItemsRecepcionME mensajeEntrada)
    {
        var respuesta = _servicioCmd.NuevoItemRecepcion(mensajeEntrada);
        return Ok(respuesta);
    }

    [HttpPost(Name = "EliminarItemRecepcion")]
    [ProducesResponseType(typeof(ItemsRecepcionMS), (int)HttpStatusCode.OK)]
    public IActionResult EliminarItemRecepcion([FromBody] ItemsRecepcionME mensajeEntrada)
    {
        var respuesta = _servicioCmd.EliminarItemRecepcion(mensajeEntrada);
        return Ok(respuesta);
    }
}
