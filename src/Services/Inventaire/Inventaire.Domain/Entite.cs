using System;

namespace Inventaire.Domain
{
    public abstract class Entite
    {

        public Entite()
        {
            this.DateCreation = DateTime.Now;
        }

        public int Id { get; protected set; }
        public DateTime DateCreation { get; private set; }
    }
}