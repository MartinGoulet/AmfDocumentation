using System.Collections.Generic;
using System.Threading.Tasks;

namespace Serveur.API.Entites.Interfaces
{
    public interface IServeurRepository : IRepository<Model.Serveurs.Serveur>
    {
        Task<IEnumerable<Model.Serveurs.Serveur>> GetLastAddedAsync(int nb);

        Task<Model.Serveurs.Serveur> GetServeurWithIncludeAsync(int id);
    }
}