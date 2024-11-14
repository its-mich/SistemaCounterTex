using SistemaCounterTex.Models;

namespace SistemaCounterTex.Data.repositories.interfaz
{
    public interface IEmpleado
    {
        Task<List<PerfilEmpleado>> GetEmpleado();
        Task<bool> PostEmpleado(PerfilEmpleado perfilEmpleado);
        Task<bool> PutEmpleado(PerfilEmpleado perfilEmpleado);
        Task<bool> DeleteEmpleado(PerfilEmpleado perfilEmpleado);
    }
}
