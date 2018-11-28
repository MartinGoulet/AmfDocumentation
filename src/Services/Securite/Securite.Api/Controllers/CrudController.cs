using System.Collections.Generic;
using System.Threading.Tasks;
using Securite.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Securite.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrudController<TEntite, TRepository> : ControllerBase
        where TEntite : Entite
        where TRepository : IRepository<TEntite>
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

            TEntite entite = await GetEntiteById(id);

            if (entite == null)
            {
                return NotFound();
            }

            return Ok(entite);

        }

        protected virtual async Task<TEntite> GetEntiteById(int id) => await Repository.GetAsync(id);

    }
}