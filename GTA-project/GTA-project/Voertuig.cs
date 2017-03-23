using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_project
{
    class Voertuig
    {
        public Persoon bestuurder = new Persoon();

        public Voertuig()
        {
            bestuurder.Naam = "Bert";
        }

        public virtual void Rij()
        {
            Console.WriteLine("Het voertuig wordt bestuurd door {0}.", bestuurder.Naam);
        }

        public virtual void Stuur()
        {
            Console.WriteLine("Stuur!");
        }
    }
}
