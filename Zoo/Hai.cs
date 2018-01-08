using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Hai : Tier
{
    public Hai(string name) : base(name)
    {
        Console.WriteLine("Ein weißer Hai ist erschienen...Lauf");

    }
	public override void Schlafein()
	{
		Console.WriteLine("Ich darf nicht schlafen!");
	}
}

