using BackEnd.Datos;
using BackEnd.Dominio;
using BackEnd.Fachada.Implementacion;
using BackEnd.Fachada.Interfaz;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        private IFachada app;
        public PeliculasController()
        {
            app = new Fachada();
        }
        // GET: api/<PeliculasController>
        [HttpGet("/Obtener Peliculas")]
        public IActionResult GetPeliculas()
        {
            List<Peliculas> lista = null;
            try
            {
                lista = app.ObtenerPeliculas();
                return Ok(lista);
            }
            catch
            {
                return StatusCode(500, "Error Interno! Intentar más Tarde.");
            }
        }
        // GET: api/<PeliculasController>
        [HttpGet("/Obtener Clasificaciones")]
        public IActionResult GetClasificaciones()
        {
            List<Edades> lista = null;
            try
            {
                lista = app.ObtenerEdades();
                return Ok(lista);
            }
            catch
            {
                return StatusCode(500, "Error Interno! Intentar más Tarde.");
            }
        }
        // GET: api/<PeliculasController>
        [HttpGet("/Obtener Generos")]
        public IActionResult GetGeneros()
        {
            List<Genero_Pelis> lista = null;
            try
            {
                lista = app.ObtenerGenero_Pelis();
                return Ok(lista);
            }
            catch
            {
                return StatusCode(500, "Error Interno! Intentar más Tarde.");
            }
        }
        // GET api/<PeliculasController>/5
        [HttpGet("/Obtener Peliculas Filtradas")]
        public IActionResult ObtenerPeliculasXFiltro(string? titulo = null, int? idGenero = null, int? idEdad = null, string? estado = null)
        {
            List<Parametro> lstFiltros = null;
            List<Peliculas> lista = null;


            try
            {
                lstFiltros = new List<Parametro>();
                lstFiltros.Add(new Parametro("@titulo", titulo));
                lstFiltros.Add(new Parametro("@idGenero", idGenero));
                lstFiltros.Add(new Parametro("@idEdad", idEdad));
                lstFiltros.Add(new Parametro("@estado", estado));

                lista = app.ObtenerPeliculasFiltradas(lstFiltros);

                if(lista.Count == 0)
                {
                    return StatusCode(200, "No Existe Pelicula con esos Filtros");
                }
                else
                {
                    return Ok(lista);
                }

            }
            catch
            {
                return StatusCode(500, "Error Interno! Intentar más Tarde.");
            }
        }

        // POST api/<PeliculasController>
        [HttpPost("/Crear Pelicula")]
        public IActionResult Post(Peliculas oPelicula)
        {
            try
            {
                if (oPelicula == null)
                {
                    return BadRequest("Pelicula Invalida");
                }

                if (app.CrearPelicula(oPelicula))
                {
                    return Ok(oPelicula);
                }
                else
                    return NotFound("No se pudo guardar la Pelicula");
            }
            catch
            {
                return StatusCode(500, "Error");
            }
        }

        // PUT api/<PeliculasController>/5
        [HttpPut("/Alternar Estado de Pelicula")]
        public IActionResult CambiarDisponibilidadPeli(int idPelicula)
        {
            try
            {
                if (app.DarAltaOBajaPelicula(idPelicula))
                {
                    return Ok(new { Mensaje = "Estado Cambiado con éxito"});
                }
                else
                {
                    return NotFound("No se encontró una película con ID");
                }
            }
            catch
            {
                return StatusCode(500, "Error");
            }
        }
        // PUT api/<PeliculasController>/5
        [HttpPut("/Modificar Pelicula")]
        public IActionResult ModificarPelicula(Peliculas oPelicula)
        {
            try
            {
                if (oPelicula == null)
                {
                    return BadRequest("Pelicula Invalida");
                }

                if (app.ModPelicula(oPelicula))
                {
                    return Ok(oPelicula);
                }
                else
                    return NotFound("No se pudo Modificar la Pelicula");
            }
            catch
            {
                return StatusCode(500, "Error");
            }
        }
        //// DELETE api/<PeliculasController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
