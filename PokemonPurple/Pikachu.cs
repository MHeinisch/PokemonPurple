using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Pikachu : Pokemon
    {

        //member variables



        //constructor
        public Pikachu()
        {
            species = "Pikachu";
            typeOneIndex = 4;
            typeTwoIndex = 0;
        }



        //functions
        protected override void GenerateMoveList()
        {
            moveList.Add(move.tackle);
            moveList.Add(move.thundershock);
            moveList.Add(move.thunderbolt);
            moveList.Add(move.thunder);
            moveList.Add(move.surf);
        }

    }

}
