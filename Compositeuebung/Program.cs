using System;

namespace Compositeuebung
{
    class Program
    {
        static void Main(string[] args)
        {
            Mitarbeiter MA1 = new TeamMitglied("Eddy Lackmann", "eddy.lackmann@blacky.de");
            Mitarbeiter MA2 = new TeamMitglied("Asana Funky", "asana.funky@blacky.de");
            Mitarbeiter teamLeiter = new Teamleiter("Der schwarze", "team.boss@blacky.de");
            teamLeiter.Adden(MA1);
            teamLeiter.Adden(MA2);
            Console.WriteLine(teamLeiter.GetInfos());
            Console.Read();

        }
    }
}
