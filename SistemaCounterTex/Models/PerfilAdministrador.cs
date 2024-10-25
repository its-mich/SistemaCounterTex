using SistemaCounterTex.Models;

namespace SistemaCounterTex.Models
{
    public class PerfilAdministrador
    {
        public int ProduccionDiaria { get; set; }
        public int CantidadOperaciones { get; set; }
        public string Rol { get; set; } = null!;

        // Relaciones
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; } = null!;
    }
}
