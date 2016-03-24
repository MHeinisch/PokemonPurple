using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Pinsir : Pokemon
    {

        //member variables



        //constructor
        public Pinsir()
        {
            species = "Pinsir";
            typeOneIndex = 12;
            typeTwoIndex = 0;
            moveList.Add(new Tackle());
            moveList.Add(new StruggleBug());
            moveList.Add(new X_Scissor());
            moveList.Add(new Megahorn());
            moveList.Add(new AuraSphere());
        }



        //functions
    }

}
