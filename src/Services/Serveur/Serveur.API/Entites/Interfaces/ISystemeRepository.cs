using System.Collections.Generic;
using System.Threading.Tasks;


namespace Serveur.API.Entites.Interfaces
{
    public interface ISystemeRepository : IRepository<Model.Systemes.Systeme>
    {
        Task<Model.Systemes.Systeme> GetSystemeWithIncludeAsync(int id);
    }
}