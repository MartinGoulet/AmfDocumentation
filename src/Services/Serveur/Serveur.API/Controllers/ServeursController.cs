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
    public class ServeursController : ControllerBase
    {
        private readonly IServeurRepository _contexte;

        public ServeursController(IServeurRepository contexte)
        {
            _contexte = contexte;
        }

        /// <summary>
        /// Obtenir la liste des serveurs
        /// </summary>
        /// <returns>Liste des serveurs</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Srv.Serveur>>> Get() => Ok(await _contexte.GetAllAsync());

        /// <summary>
        /// Obtenir un serveur selon son identifiant
        /// </summary>
        /// <param name="id">Identifiant du serveur</param>
        /// <returns>Information du serveur</returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Srv.Serveur>> GetById(int id)
        {

            Srv.Serveur serveur = await _contexte.GetAsync(id);

            if (serveur == null)
            {
                return NotFound();
            }

            return Ok(serveur);

        }

        /// <summary>
        /// Obtenir un serveur selon son identifiant
        /// </summary>
        /// <param name="id">Identifiant du serveur</param>
        /// <returns>Information du serveur</returns>
        [HttpGet]
        [Route("GetLastAdded/{nombre}")]
        public async Task<ActionResult<Srv.Serveur>> GetLastAdded(int nombre)
        {

            return Ok(await _contexte.GetLastAddedAsync(nombre));

        }
    }
}