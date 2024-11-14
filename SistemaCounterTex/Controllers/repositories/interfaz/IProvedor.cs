using SistemaCounterTex.Models;

namespace SistemaCounterTex.Controllers.repositories.interfaz
{
    public interface IProvedor
    {
        Task<List<Proveedor>> GetProveedor();
        Task<bool> PostProveedor(Proveedor proveedor);
        Task<bool> PutProveedor(Proveedor proveedor);
        Task<bool> DeleteProveedor(Proveedor proveedor);
    }
}
