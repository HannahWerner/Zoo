using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Tier
{
    private string _name;
	//public string Name { get { return _name; } private set { _name = value; } }

	public string Name { get; private set; }
    
	public int Alter { get; protected set; }
	//public string GetName()
	//{
	//	return _name;

	//}

	//	public void SetName(string name)
	//{
	//	if (name == "Name")
	//	{
	//		_name = name;
	//	}
	//}

	
	
    public Tier(string name)
    {
        _name = name;


    }
    public virtual void Füttern()
    {

        Console.WriteLine("NomNomNom");
        Console.WriteLine("Das Tier mit folgendem Namen wurde gefüttert: " + _name);
    }

	public abstract void Schlafein();
}

