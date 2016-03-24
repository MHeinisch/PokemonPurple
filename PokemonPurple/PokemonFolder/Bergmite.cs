using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Bergmite : Pokemon
    {

        //member variables
        



        //constructor
        public Bergmite()
        {
            species = "Bergmite";
            typeOneIndex = 6;
            typeTwoIndex = 0;
            moveList.Add(new Tackle());
            moveList.Add(new PowderSnow());
            /*moveList.Add(new IceBeam());
            moveList.Add(new Blizzard());
            moveList.Add(new NightSlash());*/
        }



        //functions


    }

}
