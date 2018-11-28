using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Serveur.API.Entites.Interfaces;
using Serveur.API.Model;

namespace Serveur.API.Donnees.Repositories
{
    public class ServeurRepository : Repository<Model.Serveurs.Serveur, ServeurContext>, IServeurRepository
    {
        public ServeurRepository(ServeurContext contexte) : base(contexte)
        {
        }

        public async Task<IEnumerable<Model.Serveurs.Serveur>> GetLastAddedAsync(int nb) => 
            await _contexte.Serveurs
                  .Include(w => w.GroupeServeur).Include(w => w.Environnement)
                  .OrderByDescending(x => x.Id)
                  .Take(nb).ToArrayAsync();

        public async Task<Model.Serveurs.Serveur> GetServeurWithIncludeAsync(int id) => 
            await _contexte.Serveurs
                  .Include(w => w.Environnement)
                  .Include(w => w.GroupeServeur)
                  .SingleOrDefaultAsync(x => x.Id == id);

    }
}