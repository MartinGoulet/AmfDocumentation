using System;
using Serveur.API.Infrastructure.Repositories;

namespace Serveur.API.Model
{
    public class Serveur : Entite
    {
        public Serveur()
        {
            this.DateCreation = DateTime.Now;
        }

        public string Nom { get; set; }
        public string Domaine { get; set; }
        public DateTime DateCreation { get; private set; }

    }
}