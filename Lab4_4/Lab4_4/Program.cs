using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{ 
    class Program
    {  
        static void Main(string[] args)
        {
            Console.Write("Input katet1: ");
            var katet1 = Console.ReadLine();
            Console.Write("Input katet2: ");
            var katet2 = Console.ReadLine();
            var Gipotenuza = Math.Sqrt(Math.Pow(Convert.ToDouble(katet1), 2) + Math.Pow(Convert.ToDouble(katet2), 2));
            var Perimetr = Convert.ToDouble(katet1) + Convert.ToDouble(katet2) + Convert.ToDouble(Gipotenuza);
            var Ploshad = (Convert.ToDouble(katet1) * Convert.ToDouble(katet2)) / 2;
            Console.WriteLine($"Perimetr={Perimetr}");
            Console.WriteLine($"Ploshad={Ploshad}");
            Console.Write("Press ENTER to continue...");
            Console.ReadLine();
        }
}   }

           