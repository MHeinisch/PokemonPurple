using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Klink : Pokemon
    {

        //member variables



        //constructor
        public Klink()
        {
            species = "Klink";
            typeOneIndex = 17;
            typeTwoIndex = 0;
        }



        //functions
        protected override void GenerateMoveList()
        {
            moveList.Add(move.tackle);
            moveList.Add(move.bulletpunch);
            moveList.Add(move.flashcannon);
            moveList.Add(move.irontail);
            moveList.Add(move.thunderbolt);
        }

    }

}
