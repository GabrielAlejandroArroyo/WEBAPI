using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.Models;

namespace webapi.Services
{
    public class CategoriaServices : ICategoriaServices
    {
        TareasContext context;

        public CategoriaServices(TareasContext dbcontext)
        {
            context = dbcontext;

        }
        public IEnumerable<Categoria> Get()
        {
            return context.Categorias;

        }

        public async Task save(Categoria categoria)
        {
            context.Add(categoria);
            await context.SaveChangesAsync();
        }

        public async Task update(Guid id, Categoria categoria)
        {
            var categoriaActual = context.Categorias.Find(id);
            if (categoriaActual != null)
            {
                categoriaActual = categoria;
                await context.SaveChangesAsync();
            }
        }

        public async Task Delete(Guid id)
        {
            var categoriaActual = context.Categorias.Find(id);

            if (categoriaActual != null)
            {
                context.Remove(categoriaActual);
            }
        }
    }

    public interface ICategoriaServices
    {
        IEnumerable<Categoria> Get();
        Task save(Categoria categoria);
        Task update(Guid id, Categoria categoria);
        Task Delete(Guid id);


    }

}