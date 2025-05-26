using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Dominio.Entidades
{
    [Table("Persona")]
    public class Persona
    {
        [Key]
        [NotNull]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPersona { get; set; }

        [NotNull]
        [MaxLength(100)]
        public string? Nombre { get; set; }

        [NotNull]
        [MaxLength(50)]
        public string? Email { get; set; }

        [NotNull]
        public bool AceptacionDeTerminos { get; set; }

        [NotNull]
        public bool AceptacionDePoliticaDePrivacidad { get; set; }

        [NotNull]
        public bool Activa { get; set; } = true;

        public bool EmailEsValidoConRegex()
        {
            if (string.IsNullOrWhiteSpace(Email))
                return false;

            // Expresión regular básica para validar emails
            var regex = new System.Text.RegularExpressions.Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
            return regex.IsMatch(Email);
        }

        public bool NombreEsValido()
        {
            if (string.IsNullOrWhiteSpace(Nombre))
                return false;

            // Solo letras (con o sin tildes) y espacios
            var regex = new System.Text.RegularExpressions.Regex(@"^[A-Za-zÁÉÍÓÚÑáéíóúñ\s]+$");
            return regex.IsMatch(Nombre);
        }

        public bool AceptoTerminos()
        {
            return AceptacionDeTerminos;
        }

        public bool AceptoPolitica()
        {
            return AceptacionDePoliticaDePrivacidad;
        }
    }
}
