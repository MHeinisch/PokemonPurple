using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Noibat : Pokemon
    {

        //member variables



        //constructor
        public Noibat()
        {
            species = "Noibat";
            typeOneIndex = 10;
            typeTwoIndex = 15;
        }



        //functions
        protected override void GenerateMoveList()
        {
            moveList.Add(move.tackle);
            moveList.Add(move.gust);
            moveList.Add(move.twister);
            moveList.Add(move.drillpeck);
            moveList.Add(move.dragonpulse);
            moveList.Add(move.hurricane);
            moveList.Add(move.dracometeor);
        }

    }

}
