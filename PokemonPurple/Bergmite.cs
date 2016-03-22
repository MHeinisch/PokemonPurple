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
        }



        //functions
        protected override void GenerateMoveList()
        {
            moveList.Add(move.tackle);
            moveList.Add(move.powdersnow);
            moveList.Add(move.icebeam);
            moveList.Add(move.blizzard);
            moveList.Add(move.nightslash);
        }

    }

}
