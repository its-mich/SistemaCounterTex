using SistemaCounterTex.Models;

namespace SistemaCounterTex.Controllers.repositories.interfaz
{
    public interface ISatelite
    {

        Task<List<Satelite>> GetSatelites();
        Task<bool> PostSatelite(Satelite satelite);
        Task<bool> PutSatelite(Satelite satelite);
        Task<bool> DeleteSatelite(Satelite satelite);


    }

}
