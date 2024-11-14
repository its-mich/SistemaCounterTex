using SistemaCounterTex.Models;

namespace SistemaCounterTex.Controllers.repositories.interfaz
{
    public interface IAdministrador
    {
        Task<List<PerfilAdministrador>> GetAdministrador();
        Task<bool> PostAdministrador(PerfilAdministrador perfilAdministrador);
        Task<bool> PutAdministrador(PerfilAdministrador perfilAdministrador);
        Task<bool> DeleteAdministrador(PerfilAdministrador perfilAdministrador);
    }
}
