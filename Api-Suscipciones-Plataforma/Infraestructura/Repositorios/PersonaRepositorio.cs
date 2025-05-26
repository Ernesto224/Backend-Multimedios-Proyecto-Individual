using Dominio.ContratosRepositorios;
using Dominio.Entidades;
using Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Repositorios
{
    public class PersonaRepositorio : IPersonaRepositorio
    {
        private readonly PersonasDbContexto contexto;

        public PersonaRepositorio(PersonasDbContexto contexto)
        {
            this.contexto = contexto;
        }

        public async Task<Persona> CrearPersona(Persona persona)
        {
            try 
            {

                await this.contexto.Personas.AddAsync(persona);
                
                var cambiosGuardados = await this.contexto.SaveChangesAsync();

                if (cambiosGuardados == 0) return null!;

                persona.IdPersona = persona.IdPersona;

                return persona;
            } 
            catch (Exception ex) 
            { 
                throw new Exception("Error al crear persona:", ex); 
            }
        }

        public async Task<List<Persona>> ObtenerPersonas()
        {
            try 
            { 
                var personas = await this.contexto.Personas
                    .Where(persona => persona.Activa)
                    .OrderByDescending(persona => persona.IdPersona)
                    .Select(persona => persona)
                    .ToListAsync();

                return personas;
            } 
            catch (Exception ex) 
            {
                throw new Exception("Error al obtener personas:", ex);
            }
        }
    }
}
