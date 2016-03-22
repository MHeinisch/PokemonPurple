using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Charmander :  Pokemon
    {

        //member variables



        //constructor
        public Charmander()
        {
            species = "Charmander";
            typeOneIndex = 2;
            typeTwoIndex = 0;
        }



        //functions
        protected override void GenerateMoveList()
        {
            moveList.Add(move.tackle);
            moveList.Add(move.ember);
            moveList.Add(move.flamethrower);
            moveList.Add(move.fireblast);
            moveList.Add(move.dragonpulse);
        }

    }

}
