using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Serveur.API.Entites.Interfaces;

namespace Serveur.API.Donnees.Repositories
{
    public class Repository<T, TDbContext> : IRepository<T>
        where T : Model.Entite
        where TDbContext : DbContext
    {
        protected readonly TDbContext _contexte;

        public Repository(TDbContext contexte)
        {
            _contexte = contexte;
        }

        async Task IRepository<T>.AjouterAsync(T entite)
        {
            await _contexte.Set<T>().AddAsync(entite);
            await _contexte.SaveChangesAsync();
        }

        async Task IRepository<T>.DetruireAsync(T entite)
        {
            _contexte.Set<T>().Remove(entite);
            await _contexte.SaveChangesAsync();
        }

        async Task<IEnumerable<T>> IRepository<T>.GetAllAsync() =>
            await _contexte.Set<T>().ToArrayAsync();

        async Task<T> IRepository<T>.GetAsync(int id) =>
            await _contexte.Set<T>().FindAsync(id);
        

        async Task IRepository<T>.ModifierAsync(T entite)
        {
            _contexte.Entry(entite).State = EntityState.Modified;
            await _contexte.SaveChangesAsync();
        }
    }
}