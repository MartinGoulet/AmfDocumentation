using Inventaire.Domain.Entites;
using Inventaire.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Inventaire.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServeurController : CrudController<Serveur, IServeurRepository>
    {
        public ServeurController(IServeurRepository repository) : base(repository)
        {
        }

    }
}