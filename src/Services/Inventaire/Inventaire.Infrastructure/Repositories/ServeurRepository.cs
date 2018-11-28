using Inventaire.Domain.Entites;
using Inventaire.Domain.Repositories;

namespace Inventaire.Infrastructure.Repositories
{
    public class ServeurRepository : Repository<Serveur, InventaireContext>, IServeurRepository
    {
        public ServeurRepository(InventaireContext contexte) : base(contexte)
        {
        }

        // public async Task<IEnumerable<Model.Serveurs.Serveur>> GetLastAddedAsync(int nb) => 
        //     await _contexte.Serveurs
        //           .Include(w => w.GroupeServeur).Include(w => w.Environnement)
        //           .OrderByDescending(x => x.Id)
        //           .Take(nb).ToArrayAsync();

        // public async Task<Model.Serveurs.Serveur> GetServeurWithIncludeAsync(int id) => 
        //     await _contexte.Serveurs
        //           .Include(w => w.Environnement)
        //           .Include(w => w.GroupeServeur)
        //           .SingleOrDefaultAsync(x => x.Id == id);

    }
}