using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Clefairy : Pokemon
    {

        //member variables



        //constructor
        public Clefairy()
        {
            species = "Clefairy";
            typeOneIndex = 18;
            typeTwoIndex = 0;
        }



        //functions
        protected override void GenerateMoveList()
        {
            moveList.Add(move.tackle);
            moveList.Add(move.fairywind);
            moveList.Add(move.dazzlinggleam);
            moveList.Add(move.moonblast);
            moveList.Add(move.psychic);
        }

    }

}
