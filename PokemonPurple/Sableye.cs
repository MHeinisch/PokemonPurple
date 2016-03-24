using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Sableye : Pokemon
    {

        //member variables



        //constructor
        public Sableye()
        {
            species = "Sableye";
            typeOneIndex = 16;
            typeTwoIndex = 14;
            moveList.Add(new Tackle());
            moveList.Add(new Pursuit());
            moveList.Add(new ShadowSneak());
            moveList.Add(new NightSlash());
            moveList.Add(new ShadowPunch());
            moveList.Add(new FoulPlay());
            moveList.Add(new ShadowBall());
        }



        //functions

    }

}
