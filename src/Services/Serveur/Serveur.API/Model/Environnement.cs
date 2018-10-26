using Serveur.API.Infrastructure.Repositories;

namespace Serveur.API.Model
{
    public class Environnement : Entite
    {
        public string Code { get; set; }
        public string Nom { get; set; }
    }
}