using Aplicacion.ContratosServicios;
using Aplicacion.DTOs;
using Aplicacion.Mappers;
using Dominio.ContratosRepositorios;

namespace Aplicacion.Servicios
{
    public class PersonaServicio : IPersonaServicio
    {
        private readonly IPersonaRepositorio personaRepositorio;

        public PersonaServicio(IPersonaRepositorio personaRepositorio)
        {
            this.personaRepositorio = personaRepositorio;
        }

        public async Task<RespuestaDTO<PersonaDTO>> CrearPersona(PersonaCrearDTO personaCrearDTO)
        {
            var personaACrear = PersonaMapeo.ToEntidad(personaCrearDTO);

            var personaEsValida = personaACrear.EmailEsValidoConRegex() && personaACrear.NombreEsValido()
                && personaACrear.AceptoTerminos() && personaACrear.AceptoPolitica();

            if (!personaEsValida)
            {
                return new RespuestaDTO<PersonaDTO>
                {
                    Mensaje = "Error: Los datos no son validos",
                    EsValido = false,
                    Objeto = null
                };
            }

            var personaGuardada = await this.personaRepositorio.CrearPersona(personaACrear);

            if (personaGuardada == null)
            {
                return new RespuestaDTO<PersonaDTO>
                {
                    Mensaje = "Error: No se pudo crear la persona",
                    EsValido = false,
                    Objeto = null
                };
            }

            return new RespuestaDTO<PersonaDTO>
            {
                Mensaje = "Exito: Persona creada exitosamente",
                EsValido = true,
                Objeto = PersonaMapeo.ToDTO(personaGuardada)
            };
        }

        public async Task<RespuestaDTO<List<PersonaDTO>>> ObtenerPersonas()
        {
            var personas = await this.personaRepositorio.ObtenerPersonas();

            if (personas == null || !personas.Any())
            {
                return new RespuestaDTO<List<PersonaDTO>>
                {
                    Mensaje = "Error: No se encontraron personas",
                    EsValido = false,
                    Objeto = []
                };
            }

            return new RespuestaDTO<List<PersonaDTO>>
            {
                Mensaje = "Exito: Personas encontradas",
                EsValido = true,
                Objeto = personas.Select(PersonaMapeo.ToDTO).ToList()
            };
        }
    }
}
