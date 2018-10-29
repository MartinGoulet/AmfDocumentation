﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serveur.API.Entites.Interfaces;

namespace Serveur.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServeursController : CrudController<Model.Serveur, IServeurRepository>
    {
        public ServeursController(IServeurRepository repository) : base(repository)
        {
        }

        /// <summary>
        /// Obtenir un serveur selon son identifiant
        /// </summary>
        /// <param name="id">Identifiant du serveur</param>
        /// <returns>Information du serveur</returns>
        [HttpGet]
        [Route("GetLastAdded/{nombre}")]
        public async Task<ActionResult<Model.Serveur>> GetLastAdded(int nombre) => 
            Ok(await Repository.GetLastAddedAsync(nombre));
    }
}