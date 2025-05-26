using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Persistencia
{
    public class PersonasDbContexto : DbContext
    {
        public PersonasDbContexto(DbContextOptions<PersonasDbContexto> options) : base(options)
        {
        }
        public DbSet<Persona> Personas { get; set; } = null!;
    }
}
