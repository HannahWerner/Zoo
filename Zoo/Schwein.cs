using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Schwein : Tier, Streichelbar
{
    private int _Schlachtcount = 0;
    public void Schlachten()
    {

        //if (_Schlachtcount == 0)
        //{


        //    Console.WriteLine("Meine Wade :(");

        //}
        //else if(_Schlachtcount == 1)
        //{
        //    Console.WriteLine("Wieso?!");


        //}

        //else
        //{
        //    Console.WriteLine("AHhhhhh!!!!!DIESE QUALEN!!");

        //}

        switch (_Schlachtcount)
        {
            case 0:
                Console.WriteLine("Wie freundlich von dir!");
                break;

            case 1:
                Console.WriteLine("Ich liebe Umarmungen!");
                break;

            case 3:
                Console.WriteLine("Langsam reichts aber, oder?");
                break;
        }


        Console.WriteLine("Folgendes Tier freut sich : " + Name);

        _Schlachtcount++;
    }
    public Schwein(string name) : base(name)
        {
            Console.WriteLine("Ein Schwein wurde geboren!");

            
        }

	public void DuHastGeburtstag()
	{
		Alter++;
	}

	public override void Füttern()
	{
		Console.WriteLine("Das Schwein mit folgenedem Namen wurde gefüttert" + Name);
	}
	public override void Schlafein()
	{
		Console.WriteLine("Grunz");
	}

}

