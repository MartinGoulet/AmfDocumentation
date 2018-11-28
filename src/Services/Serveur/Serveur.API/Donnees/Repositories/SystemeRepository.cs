using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Serveur.API.Entites.Interfaces;
using Serveur.API.Model.Systemes;

namespace Serveur.API.Donnees.Repositories
{
    public class SystemeRepository : Repository<Systeme, ServeurContext>, ISystemeRepository
    {
        public SystemeRepository(ServeurContext contexte) : base(contexte)
        {
        }

        async Task<Systeme> ISystemeRepository.GetSystemeWithIncludeAsync(int id) =>
            await _contexte.Systemes
                .Include(x => x.ZoneGroupeServeurSystemes).ThenInclude(x => x.ZoneGroupeServeur)
                .SingleOrDefaultAsync(x => x.Id == id);
    }
}