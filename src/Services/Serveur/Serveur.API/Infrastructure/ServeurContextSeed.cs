using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Serveur.API.Model;

namespace Serveur.API.Infrastructure
{
    public class ServeurContextSeed
    {
        public static async Task SeedAsync(ServeurContext context)
        {
            if (!context.Serveurs.Any())
            {
                await context.Serveurs.AddRangeAsync(ObtenirServeurs());

                await context.SaveChangesAsync();
            }
        }

        private static IEnumerable<Model.Serveur> ObtenirServeurs()
        {
            return new List<Model.Serveur>() 
            {
                new Model.Serveur() { Nom = "SQ-PAPP39", Domaine = "reso.local"},
                new Model.Serveur() { Nom = "SM-DAPP54", Domaine = "dev.local"},
                new Model.Serveur() { Nom = "SM-DCRM10", Domaine = "dev.local"},
                new Model.Serveur() { Nom = "SQ-PAPP108", Domaine = "reso.local"},
                new Model.Serveur() { Nom = "SQ-PAPP107", Domaine = "reso.local"},
                new Model.Serveur() { Nom = "SQ-PBDD09", Domaine = "reso.local"}
            };
        }
    }
}