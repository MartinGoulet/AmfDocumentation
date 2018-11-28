using System.Collections.Generic;
using System.Threading.Tasks;
using Inventaire.Domain.Entites;
using Inventaire.Domain.Repositories;

namespace Inventaire.Infrastructure.Repositories
{
    public class EnvironnementRepository : Repository<Environnement, InventaireContext>, IEnvironnementRepository
    {
        public EnvironnementRepository(InventaireContext contexte) : base(contexte)
        {
            
        }

    }
}