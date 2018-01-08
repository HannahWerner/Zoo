using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class Pikachu : Tier, Streichelbar
{
    public Pikachu(string name) : base(name)
    {
        Console.WriteLine("Ein wildes Pikachu ist aufgetaucht! Düddledüddldüddledüddle...");
    }

    public void Schlachten()
    {
        Console.WriteLine("PI...KAA..CHUUUUUU");
    }
	public override void Schlafein()
	{
		Console.WriteLine("Pika");
	}
}

