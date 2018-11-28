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
            // Serveurs
            if (!context.Serveurs.Any())
            {
                await context.Serveurs.AddRangeAsync(ObtenirServeurs());
                await context.SaveChangesAsync();
            }

            // Groupe Serveurs
            if (!context.GroupeServeurs.Any())
            {
                await context.GroupeServeurs.AddRangeAsync(ObtenirGroupeServeurs());
                await context.SaveChangesAsync();
            }

            if (!context.ZoneGroupeServeurs.Any())
            {
                await context.ZoneGroupeServeurs.AddRangeAsync(ObtenirZoneGroupeServeurs());
                await context.SaveChangesAsync();
            }

            // Pilotage
            if (!context.Environnements.Any())
            {
                await context.Environnements.AddRangeAsync(ObtenirEnvironnements());
                await context.SaveChangesAsync();
            }

            // Systèmes
            if (!context.Systemes.Any())
            {
                await context.Systemes.AddRangeAsync(ObtenirSystemes());
                await context.SaveChangesAsync();
            }

            // Jonctions
            if (!context.ZoneGroupeServeurSystemes.Any())
            {
                await context.ZoneGroupeServeurSystemes.AddRangeAsync(ObtenirZoneGroupeServeurSystemes());
                await context.SaveChangesAsync();
            }
        }

        private static IEnumerable<Model.GroupeServeurs.ZoneGroupeServeur> ObtenirZoneGroupeServeurs()
        {
            return new List<Model.GroupeServeurs.ZoneGroupeServeur>()
            {
                new Model.GroupeServeurs.ZoneGroupeServeur() { },
                new Model.GroupeServeurs.ZoneGroupeServeur() { },
                new Model.GroupeServeurs.ZoneGroupeServeur() { },
                new Model.GroupeServeurs.ZoneGroupeServeur() { },
                new Model.GroupeServeurs.ZoneGroupeServeur() { },
                new Model.GroupeServeurs.ZoneGroupeServeur() { Zone = "INT", Categorie = "C3", Description = "MISA Zone interne" }
            };
        }

        private static IEnumerable<Model.Pilotages.Environnement> ObtenirEnvironnements()
        {
            return new List<Model.Pilotages.Environnement>()
            {
                new Model.Pilotages.Environnement() { Nom = "Unitaire", Code = "Unit"},
                new Model.Pilotages.Environnement() { Nom = "Fonctionnel", Code = "Fonct"},
                new Model.Pilotages.Environnement() { Nom = "Acceptation", Code = "Accpt"},
                new Model.Pilotages.Environnement() { Nom = "PréProduction", Code = "PProd"},
                new Model.Pilotages.Environnement() { Nom = "Production", Code = "Prod"},
                new Model.Pilotages.Environnement() { Nom = "Laboratoire", Code = "Laboratoire"}
            };
        }

        private static IEnumerable<Model.Serveurs.Serveur> ObtenirServeurs()
        {
            return new List<Model.Serveurs.Serveur>()
            {
                new Model.Serveurs.Serveur() { Nom = "SQ-PAPP39", Domaine = "reso.local", IdEnvironnement = 5},
                new Model.Serveurs.Serveur() { Nom = "SM-DAPP54", Domaine = "dev.local", IdEnvironnement = 2},
                new Model.Serveurs.Serveur() { Nom = "SM-DCRM10", Domaine = "dev.local", IdEnvironnement = 1},
                new Model.Serveurs.Serveur() { Nom = "SQ-PAPP108", Domaine = "reso.local", IdEnvironnement = 5, IdGroupeServeur = 1},
                new Model.Serveurs.Serveur() { Nom = "SQ-PAPP107", Domaine = "reso.local", IdEnvironnement = 5},
                new Model.Serveurs.Serveur() { Nom = "SQ-PBDD09", Domaine = "reso.local", IdEnvironnement = 5}
            };
        }

        private static IEnumerable<Model.GroupeServeurs.GroupeServeur> ObtenirGroupeServeurs()
        {
            return new List<Model.GroupeServeurs.GroupeServeur>()
            {
                new Model.GroupeServeurs.GroupeServeur() { Numero = 1, Description = "Systèmes d'infrastructure"},
                new Model.GroupeServeurs.GroupeServeur() { Numero = 2, Description = "Systèmes MISA"},
                new Model.GroupeServeurs.GroupeServeur() { Numero = 3, Description = "Systèmes indépendants"},
                new Model.GroupeServeurs.GroupeServeur() { Numero = 4, Description = "Système SRAD"},
                new Model.GroupeServeurs.GroupeServeur() { Numero = 5, Description = "Système RCPD"},
                new Model.GroupeServeurs.GroupeServeur() { Numero = 6, Description = "Connecteurs internes"},
                new Model.GroupeServeurs.GroupeServeur() { Numero = 7, Description = "Connecteurs MICA"},
                new Model.GroupeServeurs.GroupeServeur() { Numero = 8, Description = "Systèmes AMP"}
            };
        }

        private static IEnumerable<Model.Systemes.Systeme> ObtenirSystemes()
        {
            return new List<Model.Systemes.Systeme>()
            {
                new Model.Systemes.Systeme() { Code = "MISA", Nom = "Modernisation informatique des systèmes administratifs"},
                new Model.Systemes.Systeme() { Code = "SRAD", Nom = "Système de remboursement en assurance dépôt" }
            };
        }

        private static IEnumerable<Model.Jonctions.ZoneGroupeServeurSysteme> ObtenirZoneGroupeServeurSystemes()
        {
            return new List<Model.Jonctions.ZoneGroupeServeurSysteme>()
            {
                new Model.Jonctions.ZoneGroupeServeurSysteme() { IdZoneGroupeServeur = 1, IdSysteme = 1},
                new Model.Jonctions.ZoneGroupeServeurSysteme() { IdZoneGroupeServeur = 3, IdSysteme = 1},
                new Model.Jonctions.ZoneGroupeServeurSysteme() { IdZoneGroupeServeur = 5, IdSysteme = 2}
            };
        }
    }
}