using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Serveur.API.Model;

namespace Serveur.API.Infrastructure.Repositories.ServeurRepository
{
    public class ServeurRepository : Repository<Model.Serveur, ServeurContext>, IServeurRepository
    {
        public ServeurRepository(ServeurContext contexte) : base(contexte)
        {
        }

        public async Task<IEnumerable<Model.Serveur>> GetLastAddedAsync(int nb) => 
            await _contexte.Serveurs
                  .Include(w => w.GroupeServeur).Include(w => w.Environnement)
                  .OrderByDescending(x => x.Id)
                  .Take(nb).ToArrayAsync();
    }
}