
namespace Serveur.API.Model
{
    public class GroupeServeur : Entite
    {
        public int Categorie { get; set; }
        public string Zone { get; set; }
        public int Numero { get; set; }
        public string Description { get; set; }

        public string Nom
        {
            get
            {
                return this.ToString();
            }
        }

        public override string ToString()
        {
            return $"GS-C{Categorie}-{Zone}-{Numero}";
        }
    }
}