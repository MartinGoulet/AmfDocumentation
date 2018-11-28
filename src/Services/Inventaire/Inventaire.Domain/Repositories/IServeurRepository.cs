using System.Collections.Generic;
using System.Threading.Tasks;
using Inventaire.Domain.Entites;

namespace Inventaire.Domain.Repositories
{
    public interface IServeurRepository : IRepository<Serveur>
    {
        // Task<IEnumerable<Serveur>> GetLastAddedAsync(int nb);

        // Task<Serveur> GetServeurWithIncludeAsync(int id);
    }
}