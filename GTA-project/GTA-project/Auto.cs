using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_project
{
    class Auto : Voertuig
    {
        public Auto()
        {
            bestuurder.Naam = "Bob";
        }

        public override void Rij()
        {
            Console.WriteLine("De auto wordt bestuurd door {0}.", bestuurder.Naam);
        }

        public override void Stuur()
        {
            Console.WriteLine("Stuur!");
        }
    }
}
