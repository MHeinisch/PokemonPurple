using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Hawlucha : Pokemon
    {

        //member variables



        //constructor
        public Hawlucha()
        {
            species = "Hawlucha";
            typeOneIndex = 7;
            typeTwoIndex = 10;
        }



        //functions
        protected override void GenerateMoveList()
        {
            moveList.Add(move.tackle);
            moveList.Add(move.karatechop);
            moveList.Add(move.gust);
            moveList.Add(move.aurasphere);
            moveList.Add(move.drillpeck);
            moveList.Add(move.focusblast);
            moveList.Add(move.hurricane);
        }

    }

}
