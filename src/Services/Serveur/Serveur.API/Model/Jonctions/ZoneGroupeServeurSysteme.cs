using Serveur.API.Model.Systemes;
using Serveur.API.Model.GroupeServeurs;

namespace Serveur.API.Model.Jonctions
{
    /// <summary>
    /// Table de jonction entre GroupeServeur et Système
    /// </summary>
    public class ZoneGroupeServeurSysteme
    {
        public int IdZoneGroupeServeur { get; set; }
        public ZoneGroupeServeur ZoneGroupeServeur { get; set; }
        public int IdSysteme { get; set; }
        public Systeme Systeme { get; set; }
    }
}