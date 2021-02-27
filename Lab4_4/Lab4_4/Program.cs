using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("input Nomer: ");
                string InputNomer = Console.ReadLine();
                if (InputNomer.Length == 0)
                    break;
                char[] GosNomerSib = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'O', 'P', 'T', 'X', 'Y' };
                if (InputNomer.Length==6)
                {
                    var ValidNumber = true;
                    for (int i=0; i<6 & ValidNumber; i++)
                    {
                        if (i == 1 | i == 2 | i == 3)
                            ValidNumber &= Char.IsDigit(InputNomer[i]);
                        else ValidNumber &= (InputNomer[i].ToString().IndexOfAny(GosNomerSib) >= 0);

                    }
                    Console.Write(ValidNumber ? "номер правильный\n" : "номер неправильный\n");
                }
               else
                {
                    Console.Write("не правильно\n");
                    Console.Write("\nPress ENTER to countinue...");
                    Console.ReadLine();
                }
            }
            
        }
    }
}
