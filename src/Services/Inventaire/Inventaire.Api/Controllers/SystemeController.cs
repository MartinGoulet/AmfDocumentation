using Inventaire.Domain.Entites;
using Inventaire.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Inventaire.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemeController : CrudController<Systeme, ISystemeRepository>
    {
        public SystemeController(ISystemeRepository repository) : base(repository)
        {
        }

    }
}