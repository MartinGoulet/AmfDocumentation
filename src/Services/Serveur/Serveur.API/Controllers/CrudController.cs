using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Serveur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudController<TEntite, TRepository> : ControllerBase
        where TEntite : Model.Entite
        where TRepository : Entites.Interfaces.IRepository<TEntite>
    {
        public CrudController(TRepository repository)
        {
            Repository = repository;
        }

        public TRepository Repository { get; }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntite>>> Get() => Ok(await Repository.GetAllAsync());


        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<TEntite>> GetById(int id)
        {

            TEntite entite = await Repository.GetAsync(id);

            if (entite == null)
            {
                return NotFound();
            }

            return Ok(entite);

        }

    }
}