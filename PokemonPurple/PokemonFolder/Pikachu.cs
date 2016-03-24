using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Pikachu : Pokemon
    {
        //member variables



        //constructor
        public Pikachu()
        {
            species = "Pikachu";
            typeOneIndex = 4;
            typeTwoIndex = 0;
            moveList.Add(new Tackle());
            moveList.Add(new ThunderShock());
            /*moveList.Add(new Thunderbolt());
            moveList.Add(new Thunder());
            moveList.Add(new Surf());*/
        }



        //functions

    }

}
