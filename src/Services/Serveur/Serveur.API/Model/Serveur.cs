using System;
using System.ComponentModel.DataAnnotations.Schema;
using Serveur.API.Infrastructure.Repositories;

namespace Serveur.API.Model
{
    public class Serveur : Entite
    {
        public string Nom { get; set; }
        public string Domaine { get; set; }
        
        [ForeignKey("GroupeServuer")]
        public int? IdGroupeServeur { get; set; }
        public virtual GroupeServeur GroupeServeur { get; set; }

    }
}