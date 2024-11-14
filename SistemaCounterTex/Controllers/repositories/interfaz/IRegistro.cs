using SistemaCounterTex.Models;

namespace SistemaCounterTex.Controllers.repositories.interfaz
{
    public interface IRegistro
    {
        Task<List<Registro>> GetRegistro();
        Task<bool> PostRegistro(Registro registro);
        Task<bool> PutRegistro(Registro registro);
        Task<bool> DeleteRegistro(Satelite satelite);
    }
}
