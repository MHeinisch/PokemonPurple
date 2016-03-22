using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Carbink : Pokemon
    {

        //member variables



        //constructor
        public Carbink()
        {
            species = "Carbink";
            typeOneIndex = 13;
            typeTwoIndex = 18;
        }



        //functions
        protected override void GenerateMoveList()
        {
            moveList.Add(move.tackle);
            moveList.Add(move.rockthrow);
            moveList.Add(move.fairywind);
            moveList.Add(move.powergem);
            moveList.Add(move.dazzlinggleam);
            moveList.Add(move.stoneedge);
            moveList.Add(move.moonblast);
        }

    }

}
