using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Zoo
{
	public string ZooName { get; private set; } = "Mein Zoo";
    

    //Tier _schwein;

    //Tier[] _schweine = new Tier[3];

    List<Tier> _tiere = new List<Tier>();

  //  int _anzahlSchweine = 0;

    public Zoo(string name)
    {
        ZooName = name;
    }

    public void FütterAlleTiere()
    {
        
        //for (int i = 0; i < _schweineListe.Count; i++)
        //{

        //    _schweineListe[i].Füttern();

        //}

        foreach(Tier tier in _tiere)
        {
            tier.Füttern();


        }

        

    }
    public void SchlachteFolgendesTier(string name)
    {
        foreach(Tier tier in _tiere)
        {
            
            if(tier is Streichelbar && name == tier.Name)
            {
                Streichelbar streichelbaresTier = tier as Streichelbar;

                streichelbaresTier.Schlachten();
            }
        }


    }
    public void NeuerHai(string name)
    {

        Hai neuerHai = new Hai(name);
        _tiere.Add(neuerHai);
        
    }

    public void NeuerWal(string name)
    {

        Wal neuerWal = new Wal(name);
        _tiere.Add(neuerWal);
        neuerWal.Schlachten();
    }
    public void NeuesPikachu(string name)
    {

        Pikachu neuesPikachu = new Pikachu(name);
        _tiere.Add(neuesPikachu);
        neuesPikachu.Schlachten();
    }


    public void NeuesSchwein(string name)
    {
        //bool gibtEsSchon = false;
        //for (int i = 0; i < _schweineListe.Count; i++)
        //{
        //    if (name == _schweineListe[i].Name)
        //    {
        //        gibtEsSchon = true;
        //    }


        //}



        // if(gibtEsSchon == false)
        if (_tiere.Exists(tier => tier.Name == name) ==false)
        {
            // _schweine[0] = new Tier(name);

            _tiere.Add(new Schwein(name));

            Console.WriteLine("Ein neues Schwein ist da! Oink");
            Console.WriteLine("Dein Schwein heißt: " + _tiere[_tiere.Count - 1].Name);

            //_anzahlSchweine += 1;
            //_anzahlSchweine =_anzahlSchweine + 1;
            // _anzahlSchweine ++;

            Console.WriteLine("Deine Anzahl Schweine ist nun: " + _tiere.Count);

        }
        else
        {
            Console.WriteLine("Der folgende Name existiert schon: " + name);
            Console.WriteLine("Deine Anzahl bleibt: " + _tiere.Count);

        }
    
    }

}
