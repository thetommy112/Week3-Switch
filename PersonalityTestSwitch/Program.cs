using System;

namespace PersonalityTestSwitch
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

            string userColor = Console.ReadLine().ToLower(); //Teeb kõik väikesteks tähtedeks

            switch (userColor)
            {
                case "punane": //if(userColor == "punane")
                    Console.WriteLine("Oled romantiline.");
                    break; //väljub selle juhtumi ülesandest
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled Looduse sõber.");
                    break;
                default: //kui ei kehti ükski ettemääratud tingimus valitakse default
                    Console.WriteLine($"Oled {userColor} ükssarvik.");
                    break;
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
