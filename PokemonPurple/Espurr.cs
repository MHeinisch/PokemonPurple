using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Espurr : Pokemon
    {

        //member variables



        //constructor
        public Espurr()
        {
            species = "Espurr";
            typeOneIndex = 11;
            typeTwoIndex = 0;
        }



        //functions
        protected override void GenerateMoveList()
        {
            moveList.Add(move.tackle);
            moveList.Add(move.confusion);
            moveList.Add(move.psychic);
            moveList.Add(move.psychoboost);
            moveList.Add(move.dazzlinggleam);
        }

    }

}
