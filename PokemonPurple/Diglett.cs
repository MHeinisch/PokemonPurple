using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Diglett : Pokemon
    {

        //member variables



        //constructor
        public Diglett()
        {
            species = "Diglett";
            typeOneIndex = 9;
            typeTwoIndex = 0;
        }



        //functions
        protected override void GenerateMoveList()
        {
            moveList.Add(move.tackle);
            moveList.Add(move.mudshot);
            moveList.Add(move.earthpower);
            moveList.Add(move.earthquake);
            moveList.Add(move.powergem);
        }

    }

}
