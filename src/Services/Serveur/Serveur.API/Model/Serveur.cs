using System;
using System.ComponentModel.DataAnnotations.Schema;
using Serveur.API.Infrastructure.Repositories;

namespace Serveur.API.Model
{
    public class Serveur : Entite
    {
        public string Nom { get; set; }
        public string Domaine { get; set; }

        #region "Propriétés Navigations"

        [ForeignKey("GroupeServeur")]
        public int? IdGroupeServeur { get; set; }
        public virtual GroupeServeur GroupeServeur { get; set; }


        [ForeignKey("Environnement")]
        public int? IdEnvironnement { get; set; }
        public virtual Environnement Environnement { get; set; }

        #endregion

    }
}