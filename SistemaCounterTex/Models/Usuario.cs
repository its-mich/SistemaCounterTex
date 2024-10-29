namespace SistemaCounterTex.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }

        // Relaciones
        public ICollection<Satelite> Satelites { get; set; }
    }
}
