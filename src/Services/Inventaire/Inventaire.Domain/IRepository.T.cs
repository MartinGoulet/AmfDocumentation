using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inventaire.Domain
{
    public interface IRepository<T> where T : Entite
    {
         Task<T> GetAsync(int id);

         Task<IEnumerable<T>> GetAllAsync();

         Task AjouterAsync(T entite);

         Task ModifierAsync(T entite);

         Task DetruireAsync(T entite);
    }
}