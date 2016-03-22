using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Squirtle : Pokemon
    {

        //member variables



        //constructor
        public Squirtle()
        {
            species = "Squirtle";
            typeOneIndex = 3;
            typeTwoIndex = 0;
        }



        //functions
        protected override void GenerateMoveList()
        {
            moveList.Add(move.tackle);
            moveList.Add(move.watergun);
            moveList.Add(move.surf);
            moveList.Add(move.hydropump);
            moveList.Add(move.icebeam);
        }

    }

}
