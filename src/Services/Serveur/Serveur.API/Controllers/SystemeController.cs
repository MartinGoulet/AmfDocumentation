using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serveur.API.Entites.Interfaces;
using Serveur.API.Model;

namespace Serveur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemeController : CrudController<Model.Systemes.Systeme, ISystemeRepository>
    {
        public SystemeController(ISystemeRepository repository) : base(repository)
        {
        }

        protected override async Task<Model.Systemes.Systeme> GetEntiteById(int id) => 
            await Repository.GetSystemeWithIncludeAsync(id);

    }
}