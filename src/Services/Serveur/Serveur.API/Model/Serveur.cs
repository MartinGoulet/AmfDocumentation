using Serveur.API.Infrastructure.Repositories;

namespace Serveur.API.Model
{
    public class Serveur : Entite
    {
        public string Nom { get; set; }
        public string Domaine { get; set; }
    }
}