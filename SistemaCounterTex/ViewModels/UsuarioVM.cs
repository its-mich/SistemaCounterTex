using SistemaCounterTex.Models;

namespace SistemaCounterTex.ViewModels
{
    public class UsuarioVM
    {
        public string NombreUsuario { get; set; } 
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string ConfirmarClave { get; set; }

        // Relaciones
        public ICollection<Satelite> Satelites { get; set; }
    }
}
