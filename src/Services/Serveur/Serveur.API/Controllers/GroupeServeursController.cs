using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serveur.API.Infrastructure;
using Serveur.API.Infrastructure.Repositories.GroupeServeurRepository;
using Srv = Serveur.API.Model;

namespace Serveur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupeServeursController : ControllerBase
    {
        private readonly IGroupeServeurRepository _contexte;

        public GroupeServeursController(IGroupeServeurRepository contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Obtenir la liste des serveurs
        /// </summary>
        /// <returns>Liste des serveurs</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Srv.GroupeServeur>>> Get() => Ok(await _contexte.GetAllAsync());

        /// <summary>
        /// Obtenir un serveur selon son identifiant
        /// </summary>
        /// <param name="id">Identifiant du serveur</param>
        /// <returns>Information du serveur</returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Srv.GroupeServeur>> GetById(int id)
        {

            Srv.GroupeServeur groupeserveur = await _contexte.GetAsync(id);

            if (groupeserveur == null)
            {
                return NotFound();
            }

            return Ok(groupeserveur);

        }

    }
}