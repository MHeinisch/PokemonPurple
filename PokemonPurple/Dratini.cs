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
        }



        //functions
        protected override void GenerateMoveList()
        {
            moveList.Add(move.tackle);
            moveList.Add(move.twister);
            moveList.Add(move.dragonpulse);
            moveList.Add(move.dracometeor);
            moveList.Add(move.surf);
        }

    }

}
