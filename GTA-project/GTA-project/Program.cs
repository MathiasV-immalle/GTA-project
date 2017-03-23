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
            Voertuig v = new Voertuig(ConsoleColor.Magenta);
            Voertuig truck = new Vrachtwagen();

            v.Rij();
            truck.Rij();
            Console.ReadLine();
        }
    }
}
