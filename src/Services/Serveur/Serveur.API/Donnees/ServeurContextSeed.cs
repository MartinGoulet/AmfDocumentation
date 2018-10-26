using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Serveur.API.Model;

namespace Serveur.API.Donnees
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

            if (!context.GroupeServeurs.Any())
            {
                await context.GroupeServeurs.AddRangeAsync(ObtenirGroupeServeurs());
                await context.SaveChangesAsync();
            }

            if (!context.Environnements.Any())
            {
                await context.Environnements.AddRangeAsync(ObtenirEnvironnements());
                await context.SaveChangesAsync();
            }
        }

        private static IEnumerable<Model.Environnement> ObtenirEnvironnements()
        {
            return new List<Model.Environnement>()
            {
                new Model.Environnement() { Nom = "Unitaire", Code = "Unit"},
                new Model.Environnement() { Nom = "Fonctionnel", Code = "Fonct"},
                new Model.Environnement() { Nom = "Acceptation", Code = "Accpt"},
                new Model.Environnement() { Nom = "PréProduction", Code = "PProd"},
                new Model.Environnement() { Nom = "Production", Code = "Prod"},
                new Model.Environnement() { Nom = "Laboratoire", Code = "Laboratoire"}
            };
        }

        private static IEnumerable<Model.Serveur> ObtenirServeurs()
        {
            return new List<Model.Serveur>()
            {
                new Model.Serveur() { Nom = "SQ-PAPP39", Domaine = "reso.local", IdEnvironnement = 5},
                new Model.Serveur() { Nom = "SM-DAPP54", Domaine = "dev.local", IdEnvironnement = 2},
                new Model.Serveur() { Nom = "SM-DCRM10", Domaine = "dev.local", IdEnvironnement = 1},
                new Model.Serveur() { Nom = "SQ-PAPP108", Domaine = "reso.local", IdEnvironnement = 5, IdGroupeServeur = 1},
                new Model.Serveur() { Nom = "SQ-PAPP107", Domaine = "reso.local", IdEnvironnement = 5},
                new Model.Serveur() { Nom = "SQ-PBDD09", Domaine = "reso.local", IdEnvironnement = 5}
            };
        }

        private static IEnumerable<Model.GroupeServeur> ObtenirGroupeServeurs()
        {
            return new List<Model.GroupeServeur>()
            {
                new Model.GroupeServeur() { Categorie = 3, Zone = "INT", Numero = 1, Description = "Systèmes d'infrastructure"},
                new Model.GroupeServeur() { Categorie = 3, Zone = "INT", Numero = 2, Description = "Systèmes MISA Interne"},
                new Model.GroupeServeur() { Categorie = 3, Zone = "EXT", Numero = 2, Description = "Systèmes MISA Externe"},
                new Model.GroupeServeur() { Categorie = 3, Zone = "INT", Numero = 3, Description = "Systèmes indépendants"},
                new Model.GroupeServeur() { Categorie = 4, Zone = "INT", Numero = 4, Description = "Système SRAD"},
                new Model.GroupeServeur() { Categorie = 3, Zone = "INT", Numero = 5, Description = "Système RCPD"},
                new Model.GroupeServeur() { Categorie = 3, Zone = "INT", Numero = 6, Description = "Connecteurs internes"},
                new Model.GroupeServeur() { Categorie = 3, Zone = "INT", Numero = 7, Description = "Connecteurs MICA"},
                new Model.GroupeServeur() { Categorie = 3, Zone = "INT", Numero = 8, Description = "Systèmes AMP Interne"},
                new Model.GroupeServeur() { Categorie = 3, Zone = "EXT", Numero = 8, Description = "Systèmes AMP Externe"},
            };
        }
    }
}