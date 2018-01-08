using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Wal : Tier, Streichelbar
{
    public Wal(string name) : base(name)
    {
        Console.WriteLine("Ein Wal ist ins Wasser gefallen!");
    }

    public void Schlachten()
    {
        Console.WriteLine("Blub");
    }

	public override void Schlafein()
	{
		Console.WriteLine("BLub");
	}

}

