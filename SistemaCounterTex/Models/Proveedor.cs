namespace SistemaCounterTex.Models
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public decimal PrecioPrenda { get; set; }
        public string TipoPrenda { get; set; } = string.Empty;
        public int Telefono { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Localidad { get; set; }
        public string Barrio { get; set; }
        public int CantidadPrendas { get; set; }
    }
}
