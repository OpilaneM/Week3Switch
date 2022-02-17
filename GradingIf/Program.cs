using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai
            //kui kasutaja sai "A", konsool kuvab "Suurepärane!"
            //kui tulemus on "B", konsool kuvab "Väga hea!"
            //kui tulemus on "C", konsool kuvab "Hea!"
            //kui kasutaja sai "D", konsool kuvab "Rahuldav"
            //kui kasutaja sai "E", konsool kuvab "Kasin"
            //kui kasutaja sai "F", konsool kuvab "Puudulik"

            Console.WriteLine("Sisesta oma tulemus:");
            // char- character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());
            if (userResult == 'A')
            {
                Console.WriteLine("Suurepärane!");
            }
            else if (userResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav.");
            }
            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin.");
            }
            else
            {
                Console.WriteLine("Puudulik.");
            }
            Console.Read();
        }
    }
}
