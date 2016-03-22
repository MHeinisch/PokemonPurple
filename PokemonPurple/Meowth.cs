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
        }



        //functions
        protected override void GenerateMoveList()
        {
            moveList.Add(move.tackle);
            moveList.Add(move.bodyslam);
            moveList.Add(move.megakick);
            moveList.Add(move.nightslash);
            moveList.Add(move.dazzlinggleam);
        }

    }

}
