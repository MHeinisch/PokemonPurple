using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Carbink : Pokemon
    {

        //member variables



        //constructor
        public Carbink()
        {
            species = "Carbink";
            typeOneIndex = 13;
            typeTwoIndex = 18;
            moveList.Add(new Tackle());
            moveList.Add(new RockThrow());
            moveList.Add(new FairyWind());
            /*moveList.Add(new PowerGem());
            moveList.Add(new DazzlingGleam());
            moveList.Add(new StoneEdge());
            moveList.Add(new Moonblast());*/
        }



        //functions

    }

}
