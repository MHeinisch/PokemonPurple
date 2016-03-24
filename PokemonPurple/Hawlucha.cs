using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Hawlucha : Pokemon
    {

        //member variables



        //constructor
        public Hawlucha()
        {
            species = "Hawlucha";
            typeOneIndex = 7;
            typeTwoIndex = 10;
            moveList.Add(new Tackle());
            moveList.Add(new KarateChop());
            moveList.Add(new Gust());
            moveList.Add(new AuraSphere());
            moveList.Add(new DrillPeck());
            moveList.Add(new FocusBlast());
            moveList.Add(new Hurricane());
        }



        //functions

    }

}
