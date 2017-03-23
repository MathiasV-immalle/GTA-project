using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTA_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Voertuig v = new Voertuig();
            Voertuig truck = new Vrachtwagen();
            Voertuig car = new Auto();

            car.Rij();
            car.Stuur();
            v.Rij();
            truck.Rij();
            truck.Stuur();
            Console.ReadLine();
        }
    }
}
