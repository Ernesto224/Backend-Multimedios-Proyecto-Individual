using Aplicacion.DTOs;
using Dominio.Entidades;

namespace Aplicacion.ContratosServicios
{
    public interface IPersonaServicio
    {
        public Task<RespuestaDTO<List<PersonaDTO>>> ObtenerPersonas();

        public Task<RespuestaDTO<PersonaDTO>> CrearPersona(PersonaCrearDTO personaCrearDTO);
    }
}
