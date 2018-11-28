using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Securite.Domain.Entites;

namespace Securite.Infrastructure
{
    public class SecuriteContextSeed
    {
        public static async Task SeedAsync(SecuriteContext context)
        {
            if (!context.Systemes.Any())
            {
                await context.Systemes.AddRangeAsync(ObtenirSystemes());
                await context.SaveChangesAsync();
            }

            if (!context.Environnements.Any())
            {
                await context.Environnements.AddRangeAsync(ObtenirEnvironnements());
                await context.SaveChangesAsync();
            }
            
        }

        private static IEnumerable<Systeme> ObtenirSystemes()
        {
            return new List<Systeme>()
            {
                new Systeme() { Code = "MISA", Nom = "Modernisation informatique des systèmes administratifs"},
                new Systeme() { Code = "SRAD", Nom = "Système de remboursement en assurance dépôt" }
            };
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

    }
}