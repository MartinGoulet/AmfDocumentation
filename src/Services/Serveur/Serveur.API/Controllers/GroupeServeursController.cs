using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serveur.API.Entites.Interfaces;
using Serveur.API.Model.GroupeServeurs;

namespace Serveur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupeServeursController : CrudController<GroupeServeur, IGroupeServeurRepository>
    {
        public GroupeServeursController(IGroupeServeurRepository repository) : base(repository)
        {
        }

    }

}