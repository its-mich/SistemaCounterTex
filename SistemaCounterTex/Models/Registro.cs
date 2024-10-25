 namespace SistemaCounterTex.Models
{
    public class Registro
    {
        public int RegistroId { get; set; }
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public int Documento { get; set; } 
        public string Correo { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
        public string ConfirmarContraseña { get; set; } = null!;

    }
}
