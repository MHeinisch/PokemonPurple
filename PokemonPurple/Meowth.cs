using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Meowth : Pokemon
    {

        //member variables



        //constructor
        public Meowth()
        {
            species = "Meowth";
            typeOneIndex = 1;
            typeTwoIndex = 0;
            moveList.Add(new Tackle());
            moveList.Add(new BodySlam());
            moveList.Add(new MegaKick());
            moveList.Add(new NightSlash());
            moveList.Add(new DazzlingGleam());
        }



        //functions

    }

}
