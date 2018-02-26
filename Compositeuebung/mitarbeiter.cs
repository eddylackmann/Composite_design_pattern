using System;
using System.Collections.Generic;
using System.Text;

namespace Compositeuebung
{
    public abstract class Mitarbeiter
    {
        protected string name;
        protected double salary;
        protected string email;
        protected int telefonnumer;
        protected bool blockiert;

        public Mitarbeiter(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        public abstract void Adden(Mitarbeiter mitarbeiter);
        public abstract void Löschen(Mitarbeiter mitarbeiter);
        public abstract string GetInfos();
    }
   
}
