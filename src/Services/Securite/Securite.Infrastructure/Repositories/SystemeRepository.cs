using Securite.Domain.Entites;
using Securite.Domain.Repositories;

namespace Securite.Infrastructure.Repositories
{
    public class SystemeRepository : Repository<Systeme, SecuriteContext>, ISystemeRepository
    {
        public SystemeRepository(SecuriteContext contexte) : base(contexte)
        {
        }

        // async Task<Systeme> ISystemeRepository.GetSystemeWithIncludeAsync(int id) =>
        //     await _contexte.Systemes
        //         .Include(x => x.ZoneGroupeServeurSystemes).ThenInclude(x => x.ZoneGroupeServeur)
        //         .SingleOrDefaultAsync(x => x.Id == id);
    }
}