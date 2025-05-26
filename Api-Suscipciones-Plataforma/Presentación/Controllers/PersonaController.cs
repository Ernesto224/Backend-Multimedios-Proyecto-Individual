using Aplicacion.ContratosServicios;
using Aplicacion.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Presentacion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaServicio personaServicio;

        public PersonaController(IPersonaServicio personaServicio)
        {
            this.personaServicio = personaServicio;
        }

        // GET: api/<PersonaController>
        [HttpGet]
        public async Task<ActionResult<RespuestaDTO<List<PersonaDTO>>>> Get()
        {
            try 
            {
                var respuesta = await this.personaServicio.ObtenerPersonas();

                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<PersonaController>
        [HttpPost]
        public async Task<ActionResult<RespuestaDTO<PersonaDTO>>> Post(PersonaCrearDTO personaCrearDTO)
        {
            try
            {
                var respuesta = await this.personaServicio.CrearPersona(personaCrearDTO);

                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
