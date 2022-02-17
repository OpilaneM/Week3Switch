using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajalt "Sisestada tema lemmikvärv";
            //Kui kasutaja sisestab "Punane", konsool kuvab oled romantiline;
            //Kui kasutaja sisestab "Sinine", konsool kuvab oled töökas;
            //Kui kasutaja sisestab "Roheline", konsool kuvab oled looduse sõber;
            //Kui kasutaja sisetab midagi muud, konsool kuvab "oled userColor} ükssarvik";

            Console.WriteLine("Sisesta oma lemmikvärv.");
            String userColor = Console.ReadLine();

            if (userColor == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            else if (userColor == "sinine")
            {
                Console.WriteLine("Oled töökas.");

            }
            else if (userColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber.");
            }

            else
            {
                Console.WriteLine($"Oled {userColor} ükssarvik.");
            }

            Console.WriteLine("Kena päeva!");
            Console.Read();

    }
    }
}
