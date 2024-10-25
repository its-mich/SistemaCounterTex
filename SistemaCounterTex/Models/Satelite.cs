using SistemaCounterTex.Models;

namespace SistemaCounterTex.Models
{
    public class Satelite
    {
        public int SateliteId { get; set; }
        public string AreaTrabajo { get; set; } = null!;
        public string Domicilio { get; set; } = null!;
        public int ProduccionMensual { get; set; }

        // Relaciones
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; } = null!;
    }
}
