using SistemaCounterTex.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaCounterTex.Models
{
    public class PerfilAdministrador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int IdAdministrador { get; set; }
        public string? NombreAdministrador { get; set; }
        public int ProduccionDiaria { get; set; }
        public int ProduccionMensual { get; set; }
        public int ControlPrendas { get; set; }
        public string? Registro { get; set; }
        public int Ganancias { get; set; }
        public int Pagos { get; set; }
        public int Gastos { get; set; }
        public int MetaPorCorte { get; set; }
        public bool ConsultarInformacion { get; set; }
        public DateTime ControlHorarios { get; set; }
        public string? ChatInterno { get; set; }
        public string? Proveedor { get; set; }
        public string? BotonAyuda { get; set; }

        // Relaciones
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; } = null!;
    }
}
