using System;
using System.Collections.Generic;
using System.Text;

namespace Compositeuebung
{
    public class Teamleiter : Mitarbeiter

    {
        List<Mitarbeiter> MitarbeiterListe = new List<Mitarbeiter>();

        public Teamleiter(string name, string email) : base(name, email) { }

        public override void Adden(Mitarbeiter mitarbeiter)

        {

            MitarbeiterListe.Add(mitarbeiter);

        }

        public override void Löschen(Mitarbeiter mitarbeiter)

        {

            MitarbeiterListe.Remove(mitarbeiter);

        }

        public override string GetInfos()

        {

            StringBuilder SB_Mitarbeiter = new StringBuilder();

            foreach(Mitarbeiter ma in MitarbeiterListe)

            {

                SB_Mitarbeiter.Append(ma.GetInfos() + "\n");

            }

            return "Team Leiter: " + this.name + "\n" + "\n ****Teammitglieder**** \n" + SB_Mitarbeiter.ToString();

        }

    }
}
