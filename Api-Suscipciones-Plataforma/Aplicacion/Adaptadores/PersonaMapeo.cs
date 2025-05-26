using Dominio.Entidades;
using Aplicacion.DTOs;

namespace Aplicacion.Mappers
{
    public static class PersonaMapeo
    {
        public static PersonaDTO ToDTO(Persona persona)
        {
            return new PersonaDTO
            {
                IdPersona = persona.IdPersona,
                Nombre = persona.Nombre,
                Email = persona.Email,
                AceptacionDeTerminos = persona.AceptacionDeTerminos,
                AceptacionDePoliticaDePrivacidad = persona.AceptacionDePoliticaDePrivacidad
            };
        }

        public static Persona ToEntidad(PersonaCrearDTO dto)
        {
            return new Persona
            {
                Nombre = dto.Nombre,
                Email = dto.Email,
                AceptacionDeTerminos = dto.AceptacionDeTerminos,
                AceptacionDePoliticaDePrivacidad = dto.AceptacionDePoliticaDePrivacidad,
            };
        }
    }
}