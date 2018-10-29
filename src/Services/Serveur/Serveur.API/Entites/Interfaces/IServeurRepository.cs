using System.Collections.Generic;
using System.Threading.Tasks;

namespace Serveur.API.Entites.Interfaces
{
    public interface IServeurRepository : IRepository<Model.Serveur>
    {
        Task<IEnumerable<Model.Serveur>> GetLastAddedAsync(int nb);

        Task<Model.Serveur> GetServeurWithIncludeAsync(int id);
    }
}