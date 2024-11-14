using Microsoft.EntityFrameworkCore;
using SistemaCounterTex.Data.repositories.interfaz;
using SistemaCounterTex.Models;

namespace SistemaCounterTex.Data.repositories
{
    public class RepositorioUsuarios : IUsuarios
    {
        private readonly CounterTexDBContext context;
        public RepositorioUsuarios(CounterTexDBContext context)
        {
            this.context = context;
        }
        public async Task<List<Usuario>> GetUsuarios()
        {
            var data = await context.Usuarios.ToListAsync();
            return data;
        }
        public async Task<bool> PostUsuarios (Usuario usuario)
        {
            await context.Usuarios.AddAsync(usuario);
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> PutUsuarios(Usuario usuario)
        {
            context.Usuarios.Update(usuario);
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteUsuarios(Usuario usuario)
        {
            context.Usuarios.Remove(usuario);
            await context.SaveChangesAsync();
            return true;
        }

    }
}
