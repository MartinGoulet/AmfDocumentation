using Inventaire.Domain.Entites;
using Inventaire.Domain.Repositories;

namespace Inventaire.Infrastructure.Repositories
{
    public class SystemeRepository : Repository<Systeme, InventaireContext>, ISystemeRepository
    {
        public SystemeRepository(InventaireContext contexte) : base(contexte)
        {
        }

        // async Task<Systeme> ISystemeRepository.GetSystemeWithIncludeAsync(int id) =>
        //     await _contexte.Systemes
        //         .Include(x => x.ZoneGroupeServeurSystemes).ThenInclude(x => x.ZoneGroupeServeur)
        //         .SingleOrDefaultAsync(x => x.Id == id);
    }
}