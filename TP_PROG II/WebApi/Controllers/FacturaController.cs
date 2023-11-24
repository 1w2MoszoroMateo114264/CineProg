using BackEnd.Datos;
using BackEnd.Dominio;
using BackEnd.Fachada.Implementacion;
using BackEnd.Fachada.Interfaz;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private IFachada app;
        public FacturaController()
        {
            app = new Fachada();
        }

        // GET: api/<FacturaController>
        [HttpGet("/Funciones")]
        public IActionResult GetFunciones()
        {
            List<Funciones> list = null;
            try
            {
                list = app.ObtenerFunciones();
                return Ok(list);
            }
            catch
            {
                return StatusCode(500, "Error Interno! Intentar más Tarde.");
            }
        }
        // GET: api/<FacturaController>
        [HttpGet("/Obtener Peliculas Disponibles")]
        public IActionResult GetPeliculas()
        {
            List<Peliculas> list = null;
            try
            {
                list = app.ObtenerPeliculasDisponibles();
                return Ok(list);
            }
            catch
            {
                return StatusCode(500, "Error Interno! Intentar más Tarde.");
            }
        }
        // GET api/<FacturaController>/5
        [HttpGet("/Funciones Filtradas x Pelicula")]
        public IActionResult GetFuncionesXPelicula(int idPelicula)
        {
            List<Parametro> lstFiltro = new List<Parametro>();
            lstFiltro.Add(new Parametro("@idPelicula", idPelicula));
            List<Funciones> list = null;
            try
            {
                list = app.ObtenerFuncionesFiltradas(lstFiltro);
                return Ok(list);
            }
            catch
            {
                return StatusCode(500, "Error Interno! Intentar más Tarde.");
            }
        }
        // GET api/<FacturaController>/5
        [HttpGet("/Tipo De Entradas")]
        public IActionResult GetTipoEntrada()
        {
            List<Tipo_Entrada> list = null;
            try
            {
                list = app.ObtenerTipoEntradas();
                return Ok(list);
            }
            catch
            {
                return StatusCode(500, "Error Interno! Intentar más Tarde.");
            }
        }
        // GET api/<FacturaController>/5
        [HttpGet("/Formas de Pago")]
        public IActionResult GetFormasDePago()
        {
            List<Forma_de_pagos> list = null;
            try
            {
                list = app.ObtenerFormasPago();
                return Ok(list);
            }
            catch
            {
                return StatusCode(500, "Error Interno! Intentar más Tarde.");
            }
        }

        // GET api/<FacturaController>/5
        [HttpGet("/Butacas S/Funcion")]
        public IActionResult GetButacasXfuncion(int nroFuncion)
        {
            List<Parametro> lstFiltro = new List<Parametro>();
            lstFiltro.Add(new Parametro("@nroFuncion", nroFuncion));
            List<ButacasXFunciones> list = null;
            try
            {
                list = app.ObtenerButacas(lstFiltro);
                return Ok(list);
            }
            catch
            {
                return StatusCode(500, "Error Interno! Intentar más Tarde.");
            }
        }


        // POST api/<FacturaController>
        [HttpPost("/Insertar Factura")]
        public IActionResult SaveFactura(Factura oFactura)
        {
            try
            {
                if (oFactura == null)
                    return BadRequest("Factura Invalida");
                if (app.SaveFactura(oFactura))
                    return Ok(oFactura);
                else
                    return NotFound("No se pudo guardar la Factura");
            }
            catch
            {
                return StatusCode(500, "Error");
            }
        }

        // PUT api/<FacturaController>/5
        [HttpPut("/Modificar Estado de Butaca")]
        public IActionResult CambiarEstadoButacas(List<ButacasXFunciones> listaButacas)
        {
            try
            {
                if (app.ModEstadoButaca(listaButacas))
                {
                    return Ok(new { Mensaje = "Estado Cambiado con éxito" });
                }
                else
                {
                    return NotFound("No se encontró una Butaca");
                }
            }
            catch
            {
                return StatusCode(500, "Error");
            }
        }

        //// DELETE api/<FacturaController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
