using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Dratini : Pokemon
    {

        //member variables



        //constructor
        public Dratini()
        {
            species = "Dratini";
            typeOneIndex = 15;
            typeTwoIndex = 0;
            moveList.Add(new Tackle());
            moveList.Add(new Twister());
            moveList.Add(new DragonPulse());
            moveList.Add(new DracoMeteor());
            moveList.Add(new Surf());
        }



        //functions

    }

}
