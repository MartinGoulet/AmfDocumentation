using System.Collections.Generic;
using Serveur.API.Model.Jonctions;

namespace Serveur.API.Model.GroupeServeurs
{
    public class ZoneGroupeServeur : Entite
    {
        
        public int Categorie { get; set; }
        public string Zone { get; set; }
        public string Description { get; set; }
        
        public IList<ZoneGroupeServeurSysteme> GroupeServeurSystemes { get; set; }

        public string Nom
        {
            get
            {
                return this.ToString();
            }
        }

        public override string ToString()
        {
            return $"GS-C{Categorie}-{Zone}";
        }
    }
}