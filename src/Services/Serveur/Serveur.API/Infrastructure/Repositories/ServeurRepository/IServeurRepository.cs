using System.Collections.Generic;
using System.Threading.Tasks;

namespace Serveur.API.Infrastructure.Repositories.ServeurRepository
{
    public interface IServeurRepository : IRepository<Model.Serveur>
    {
        Task<IEnumerable<Model.Serveur>> GetLastAddedAsync(int nb);
    }
}