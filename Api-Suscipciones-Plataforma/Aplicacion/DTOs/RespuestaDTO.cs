namespace Aplicacion.DTOs
{
    public class RespuestaDTO<T>
    {
        public T? Objeto { get; set; }

        public bool EsValido { get; set; }

        public string? Mensaje { get; set; }
    }
}
