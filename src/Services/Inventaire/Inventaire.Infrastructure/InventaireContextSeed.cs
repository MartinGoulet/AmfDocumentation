using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventaire.Domain.Entites;

namespace Inventaire.Infrastructure
{
    public class InventaireContextSeed
    {
        public static async Task SeedAsync(InventaireContext context)
        {
            
            if (!context.Serveurs.Any())
            {
                await context.Serveurs.AddRangeAsync(ObtenirServeurs());
                await context.SaveChangesAsync();
            }

            if (!context.Environnements.Any())
            {
                await context.Environnements.AddRangeAsync(ObtenirEnvironnements());
                await context.SaveChangesAsync();
            }

            if (!context.Systemes.Any())
            {
                await context.Systemes.AddRangeAsync(ObtenirSystemes());
                await context.SaveChangesAsync();
            }
        }


        private static IEnumerable<Environnement> ObtenirEnvironnements()
        {
            return new List<Environnement>()
            {
                new Environnement() { Nom = "Unitaire", Code = "Unit"},
                new Environnement() { Nom = "Fonctionnel", Code = "Fonct"},
                new Environnement() { Nom = "Acceptation", Code = "Accpt"},
                new Environnement() { Nom = "PréProduction", Code = "PProd"},
                new Environnement() { Nom = "Production", Code = "Prod"},
                new Environnement() { Nom = "Laboratoire", Code = "Laboratoire"}
            };
        }

        private static IEnumerable<Serveur> ObtenirServeurs()
        {
            return new List<Serveur>()
            {
                new Serveur() { Nom = "SQ-PAPP39", Domaine = "reso.local"},
                new Serveur() { Nom = "SM-DAPP54", Domaine = "dev.local"},
                new Serveur() { Nom = "SM-DCRM10", Domaine = "dev.local"},
                new Serveur() { Nom = "SQ-PAPP108", Domaine = "reso.local"},
                new Serveur() { Nom = "SQ-PAPP107", Domaine = "reso.local"},
                new Serveur() { Nom = "SQ-PBDD09", Domaine = "reso.local"}
            };
        }

        private static IEnumerable<Systeme> ObtenirSystemes()
        {
            return new List<Systeme>()
            {
                new Systeme() { Code = "MISA", Nom = "Modernisation informatique des systèmes administratifs"},
                new Systeme() { Code = "SRAD", Nom = "Système de remboursement en assurance dépôt" }
            };
        }

    }
}