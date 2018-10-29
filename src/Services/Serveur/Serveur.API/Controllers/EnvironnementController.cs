using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serveur.API.Entites.Interfaces;
using Serveur.API.Model;
using Srv = Serveur.API.Model;

namespace Serveur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnvironnementController : CrudController<Environnement, IEnvironnementRepository>
    {
        public EnvironnementController(IEnvironnementRepository repository) : base(repository)
        {
        }

    }
}