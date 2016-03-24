using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Clefairy : Pokemon
    {

        //member variables



        //constructor
        public Clefairy()
        {
            species = "Clefairy";
            typeOneIndex = 18;
            typeTwoIndex = 0;
            moveList.Add(new Tackle());
            moveList.Add(new FairyWind());
            moveList.Add(new DazzlingGleam());
            moveList.Add(new Moonblast());
            moveList.Add(new Psychic());
        }



        //functions

    }

}
