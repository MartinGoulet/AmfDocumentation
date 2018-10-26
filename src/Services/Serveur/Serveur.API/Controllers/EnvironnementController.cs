using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serveur.API.Donnees.Repositories;
using Serveur.API.Entites.Interfaces;
using Srv = Serveur.API.Model;

namespace Serveur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnvironnementController : ControllerBase
    {
        private readonly IEnvironnementRepository _contexte;

        public EnvironnementController(IEnvironnementRepository contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Obtenir la liste des serveurs
        /// </summary>
        /// <returns>Liste des serveurs</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Srv.Environnement>>> Get() => Ok(await _contexte.GetAllAsync());

        /// <summary>
        /// Obtenir un serveur selon son identifiant
        /// </summary>
        /// <param name="id">Identifiant du serveur</param>
        /// <returns>Information du serveur</returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Srv.Environnement>> GetById(int id)
        {

            Srv.Environnement item = await _contexte.GetAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);

        }

    }
}