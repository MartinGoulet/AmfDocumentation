using Inventaire.Domain.Entites;
using Inventaire.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Inventaire.Api.Controllers
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