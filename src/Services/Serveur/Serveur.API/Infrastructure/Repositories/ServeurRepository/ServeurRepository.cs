using Microsoft.EntityFrameworkCore;

namespace Serveur.API.Infrastructure.Repositories.ServeurRepository
{
    public class ServeurRepository : Repository<Model.Serveur>, IServeurRepository
    {
        public ServeurRepository(ServeurContext contexte) : base(contexte)
        {
        }
    }
}