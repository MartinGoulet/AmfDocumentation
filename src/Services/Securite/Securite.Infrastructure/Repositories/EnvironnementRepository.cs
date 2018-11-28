using System.Collections.Generic;
using System.Threading.Tasks;
using Securite.Domain.Entites;
using Securite.Domain.Repositories;

namespace Securite.Infrastructure.Repositories
{
    public class EnvironnementRepository : Repository<Environnement, SecuriteContext>, IEnvironnementRepository
    {
        public EnvironnementRepository(SecuriteContext contexte) : base(contexte)
        {
            
        }

    }
}