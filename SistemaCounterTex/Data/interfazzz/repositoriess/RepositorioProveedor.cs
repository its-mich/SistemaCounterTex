using Microsoft.EntityFrameworkCore;
using SistemaCounterTex.Data.interfaz;

using SistemaCounterTex.Models;

namespace SistemaCounterTex.Data.repositories
{
    public class RepositorioProveedor : IProvedor
    {
        private readonly CounterTexDBContext context;
        public RepositorioProveedor(CounterTexDBContext context)
        {
            this.context = context;
        }
        public async Task<List<Proveedor>> GetProveedor()
        {
            var data = await context.Proveedores.ToListAsync();
            return data;
        }
        public async Task<bool> PostProveedor(Proveedor proveedor)
        {
            await context.Proveedores.AddAsync(proveedor);
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> PutProveedor(Proveedor proveedor)
        {
            context.Proveedores.Update(proveedor);
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteProveedor(Proveedor proveedor)
        {
            context.Proveedores.Remove(proveedor);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
