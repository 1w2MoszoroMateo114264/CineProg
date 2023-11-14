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

        // GET api/<FacturaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FacturaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
