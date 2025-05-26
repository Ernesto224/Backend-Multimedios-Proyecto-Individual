using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.DTOs
{
    public class PersonaDTO
    {
        public int IdPersona { get; set; }

        public string? Nombre { get; set; }

        public string? Email { get; set; }

        public bool AceptacionDeTerminos { get; set; }

        public bool AceptacionDePoliticaDePrivacidad { get; set; }
    }
}
