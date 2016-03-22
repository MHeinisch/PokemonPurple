using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Sableye : Pokemon
    {

        //member variables



        //constructor
        public Sableye()
        {
            species = "Sableye";
            typeOneIndex = 16;
            typeTwoIndex = 14;
        }



        //functions
        protected override void GenerateMoveList()
        {
            moveList.Add(move.tackle);
            moveList.Add(move.pursuit);
            moveList.Add(move.shadowsneak);
            moveList.Add(move.nightslash);
            moveList.Add(move.shadowpunch);
            moveList.Add(move.foulplay);
            moveList.Add(move.shadowball);
        }

    }

}
