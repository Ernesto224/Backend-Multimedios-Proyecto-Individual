namespace Aplicacion.DTOs
{
    public class PersonaCrearDTO
    {
        public string? Nombre { get; set; }

        public string? Email { get; set; }

        public bool AceptacionDeTerminos { get; set; }

        public bool AceptacionDePoliticaDePrivacidad { get; set; }
    }
}
