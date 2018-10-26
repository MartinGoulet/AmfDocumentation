using Serveur.API.Entites.Interfaces;

namespace Serveur.API.Donnees.Repositories
{
    public class EnvironnementRepository : Repository<Model.Environnement, ServeurContext>, IEnvironnementRepository
    {
        public EnvironnementRepository(ServeurContext contexte) : base(contexte)
        {
        }
    }
}