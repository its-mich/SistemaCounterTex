using Microsoft.EntityFrameworkCore;
using SistemaCounterTex.Data.interfaz;
using SistemaCounterTex.Models;

namespace SistemaCounterTex.Data.repositories
{
    public class RepositorioAdministrador :IAdministrador
    {
        private readonly CounterTexDBContext context;
        public RepositorioAdministrador(CounterTexDBContext context)
        {
            this.context = context;
        }
        public async Task<List<PerfilAdministrador>> GetAdministrador()
        {
            var data = await context.PerfilAdministradores.ToListAsync();
            return data;
        }
        public async Task<bool> PostAdministrador(PerfilAdministrador perfilAdministrador)
        {
            await context.PerfilAdministradores.AddAsync(perfilAdministrador);
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> PutAdministrador(PerfilAdministrador perfilAdministrador)
        {
            context.PerfilAdministradores.Update(perfilAdministrador);
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteAdministrador(PerfilAdministrador perfilAdministrador)
        {
            context.PerfilAdministradores.Remove(perfilAdministrador);
            await context.SaveChangesAsync();
            return true;
        }

        public Task<bool> DeleteAdministrador(int id)
        {
            throw new NotImplementedException();
        }
    }
}
