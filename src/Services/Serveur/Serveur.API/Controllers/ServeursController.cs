using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Srv = Serveur.API.Model;

namespace Serveur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServeursController : ControllerBase
    {
        private readonly IEnumerable<Srv.Serveur> serveurs = new Srv.Serveur[] {
            new Srv.Serveur() { Id = 1, Nom = "SQ-PAPP39", Domaine = "reso.local"},
            new Srv.Serveur() { Id = 2, Nom = "SM-DAPP54", Domaine = "dev.local"}
        };

        /// <summary>
        /// Obtenir la liste des serveurs
        /// </summary>
        /// <returns>Liste des serveurs</returns>
        [HttpGet]
        public IEnumerable<Srv.Serveur> Get()
        {
            return serveurs;
        }

        /// <summary>
        /// Obtenir un serveur selon son identifiant
        /// </summary>
        /// <param name="id">Identifiant du serveur</param>
        /// <returns>Information du serveur</returns>
        [HttpGet]
        [Route("{id}")]
        public Srv.Serveur GetById(int id) {
            return serveurs.SingleOrDefault(o => o.Id.Equals(id));
        }
    }
}