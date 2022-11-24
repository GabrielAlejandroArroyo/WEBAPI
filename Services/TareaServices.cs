using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.Models;

namespace webapi.Services
{
    public class TareaServices : ITareaServices
    {
        TareasContext context;

        public TareaServices(TareasContext dbcontext)
        {
            context = dbcontext;

        }
        public IEnumerable<Tarea> Get()
        {
            return context.Tareas;

        }

        public async Task save(Tarea tarea)
        {
            context.Add(tarea);
            await context.SaveChangesAsync();
        }

        public async Task update(Guid id, Tarea tarea)
        {
            var tareaActual = context.Tareas.Find(id);
            if (tareaActual != null)
            {
                tareaActual = tarea;
                await context.SaveChangesAsync();
            }
        }

        public async Task Delete(Guid id)
        {
            var tareaActual = context.Tareas.Find(id);

            if (tareaActual != null)
            {
                context.Remove(tareaActual);
            }
        }
    }



    public interface ITareaServices
    {
        IEnumerable<Tarea> Get();
        Task save(Tarea tarea);
        Task update(Guid id, Tarea tarea);
        Task Delete(Guid id);


    }
}