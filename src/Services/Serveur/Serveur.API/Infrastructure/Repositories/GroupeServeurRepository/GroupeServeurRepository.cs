using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Serveur.API.Model;

namespace Serveur.API.Infrastructure.Repositories.GroupeServeurRepository
{
    public class GroupeServeurRepository : Repository<Model.GroupeServeur, ServeurContext>, IGroupeServeurRepository
    {
        public GroupeServeurRepository(ServeurContext contexte) : base(contexte)
        {
        }

    }
}