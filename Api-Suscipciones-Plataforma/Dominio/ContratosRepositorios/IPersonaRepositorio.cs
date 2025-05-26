using Dominio.Entidades;

namespace Dominio.ContratosRepositorios
{
    public interface IPersonaRepositorio
    {
        public Task<List<Persona>> ObtenerPersonas();

        public Task<Persona> CrearPersona(Persona persona);
    }
}
