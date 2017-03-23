using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_project
{
    class Vrachtwagen : Voertuig
    {
        public Vrachtwagen()
        {
            bestuurder.Naam = "Bart";
        }

        public override void Rij()
        {
            Console.WriteLine("De vrachtwagen wordt bestuurd door {0}.", bestuurder.Naam);
        }

        public override void Stuur()
        {
            Console.WriteLine("De vrachtwagenchauffeur kijkt in zijn dode-hoek-spiegel...");
            Console.WriteLine("Stuur!");
        }

        public void LaadLeeg()
        {
        }
    }
}
