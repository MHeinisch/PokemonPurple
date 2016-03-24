using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Noibat : Pokemon
    {

        //member variables



        //constructor
        public Noibat()
        {
            species = "Noibat";
            typeOneIndex = 10;
            typeTwoIndex = 15;
            moveList.Add(new Tackle());
            moveList.Add(new Gust());
            moveList.Add(new Twister());
            moveList.Add(new DrillPeck());
            moveList.Add(new DragonPulse());
            moveList.Add(new Hurricane());
            moveList.Add(new DracoMeteor());
        }



        //functions

    }

}
