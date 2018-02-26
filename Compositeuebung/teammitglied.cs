using System;
using System.Collections.Generic;
using System.Text;

namespace Compositeuebung
{
    public class TeamMitglied : Mitarbeiter
    {
        public TeamMitglied(string name, string email) : base(name, email) { }
        public override void Adden(Mitarbeiter mitarbeiter)
        {
        }
        public override void Löschen(Mitarbeiter employee)
        {
        }
        public override string GetInfos()
        {
            return "Name: " + name + "\tE-Mail: " + email;
        }
    }

}
