namespace SistemaCounterTex.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Administrador { get; set; }
        public string Correo { get; set; }
        public string NombreCompleto { get; set; }
        public string Empleado { get; set; }
        public string Contraseña { get; set; } = null!;
        public string? Rol { get; set; }

        // Relaciones
        public ICollection<Satelite> Satelites { get; set; } = null!;
    }
}
