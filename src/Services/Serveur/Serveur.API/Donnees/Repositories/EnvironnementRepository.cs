using Serveur.API.Entites.Interfaces;

namespace Serveur.API.Donnees.Repositories
{
    public class EnvironnementRepository : Repository<Model.Pilotages.Environnement, ServeurContext>, IEnvironnementRepository
    {
        public EnvironnementRepository(ServeurContext contexte) : base(contexte)
        {
        }
    }
}