using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Gib einen Buchstaben ein");
        string buchstabe = Console.ReadLine();
        if (buchstabe == "a")
        {
            Console.WriteLine("Ich bin so aufgeregt!");
        }
       else if(buchstabe[0] == 'b' && buchstabe.Length == 2)
        {

            Console.WriteLine("Das ist ja toll, dass du das Programm startest!");
        }

        else
        {
            Console.WriteLine("Endlich geht es los!");
        }
        Console.WriteLine("Willkommen im Zoo! Wir haben drei Tierarten! ");

        Zoo neuerZoo = new Zoo("Zoo to Barbecue");


        for(int i = 0; i < 7; i ++)
        {

            neuerZoo.NeuesSchwein("Bacon" + i);
        }

        neuerZoo.NeuerHai("Sharkie");
        neuerZoo.NeuerWal("Walie");
        neuerZoo.NeuesPikachu("Pikachu");

        Console.WriteLine("Willst du die Tiere füttern?");
        Console.WriteLine("Für ja +, für nein anderes");
        string antwort = Console.ReadLine();
        if(antwort == "+")
        {
            Console.WriteLine("Da freuen sich die Tiere!");
            neuerZoo.FütterAlleTiere();
        }
        else
        {
            Console.WriteLine("Die armen Tiere!");
        }


        while (true)
        {
            Console.WriteLine("Welches Tier willst du streicheln?");
            string NameVonDemSchlachtSchwein = Console.ReadLine();
            neuerZoo.SchlachteFolgendesTier(NameVonDemSchlachtSchwein);
            Console.Read();
        }
        
    }

}