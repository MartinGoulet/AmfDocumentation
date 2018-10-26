namespace Serveur.API.Infrastructure.Repositories.Environnement
{
    public class EnvironnementRepository : Repository<Model.Environnement, ServeurContext>, IEnvironnementRepository
    {
        public EnvironnementRepository(ServeurContext contexte) : base(contexte)
        {
        }
    }
}