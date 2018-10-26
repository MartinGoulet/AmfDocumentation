using System.Collections.Generic;
using System.Threading.Tasks;

namespace Serveur.API.Entites.Interfaces
{
    public interface IRepository<T> where T : Serveur.API.Model.Entite
    {
         Task<T> GetAsync(int id);

         Task<IEnumerable<T>> GetAllAsync();

         Task AjouterAsync(T entite);

         Task ModifierAsync(T entite);

         Task DetruireAsync(T entite);
    }
}