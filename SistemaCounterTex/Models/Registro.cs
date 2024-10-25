namespace SistemaCounterTex.Models
{
    public class Registro
    {
        public int RegistroId { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!; 
        public string Correo { get; set; } = null!;
        public string Clave { get; set; } = null!;
    }
}
