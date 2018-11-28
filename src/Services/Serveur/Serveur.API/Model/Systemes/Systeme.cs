using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Serveur.API.Model.Jonctions;

namespace Serveur.API.Model.Systemes
{
    public class Systeme : Entite
    {
        public string Code { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }

        public IList<ZoneGroupeServeurSysteme> ZoneGroupeServeurSystemes { get; set; }
    }
}