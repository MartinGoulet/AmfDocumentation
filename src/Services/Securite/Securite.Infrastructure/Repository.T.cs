using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Securite.Domain;

namespace Securite.Infrastructure
{
    public class Repository<TEntite, TDbContext> : IRepository<TEntite>
        where TEntite : Entite
        where TDbContext : DbContext
    {
        protected readonly TDbContext _contexte;

        public Repository(TDbContext contexte)
        {
            _contexte = contexte;
        }

        public async Task AjouterAsync(TEntite entite)
        {
            await _contexte.Set<TEntite>().AddAsync(entite);
            await _contexte.SaveChangesAsync();
        }

        public async Task DetruireAsync(TEntite entite)
        {
            _contexte.Set<TEntite>().Remove(entite);
            await _contexte.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntite>> GetAllAsync() =>
            await _contexte.Set<TEntite>().ToArrayAsync();

        public async Task<TEntite> GetAsync(int id) =>
            await _contexte.Set<TEntite>().FindAsync(id);


        public async Task ModifierAsync(TEntite entite)
        {
            _contexte.Entry(entite).State = EntityState.Modified;
            await _contexte.SaveChangesAsync();
        }

    }
}