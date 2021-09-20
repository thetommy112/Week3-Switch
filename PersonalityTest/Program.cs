using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada tema lemmik varvi;
            //kui kasutaja sisestab "punane", kuvab konsool "oled romantiline";
            //kui kasutaja sisestab "sinine" kuvab konsool, "oled t;;kas";
            //kui kasutaja sisestab "roheline" kuvab "oled looduse s]ber";
            //kui kasutaja sisestab midagi muud, konsool kuvab "oled {userColor} [kssarvik";

            Console.WriteLine("Sisesta oma lemmikvärv:");

            string userColor = Console.ReadLine();


            if(userColor == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }

            else if(userColor == "sinine")
            {
                Console.WriteLine("Oled töökas.");
            }

            else if(userColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber.");
            }

            else
            {
                Console.WriteLine($"Oled {userColor} ükssarvik.");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
