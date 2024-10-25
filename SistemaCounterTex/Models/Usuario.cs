namespace SistemaCounterTex.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string Clave { get; set; } = null!;
        public string? Rol { get; set; }

        // Relaciones
        public ICollection<Satelite> Satelites { get; set; } = null!;
    }
}
