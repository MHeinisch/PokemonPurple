using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Litwick : Pokemon
    {

        //member variables



        //constructor
        public Litwick()
        {
            species = "Litwick";
            typeOneIndex = 14;
            typeTwoIndex = 2;
        }



        //functions
        protected override void GenerateMoveList()
        {
            moveList.Add(move.tackle);
            moveList.Add(move.shadowsneak);
            moveList.Add(move.ember);
            moveList.Add(move.shadowpunch);
            moveList.Add(move.flamethrower);
            moveList.Add(move.shadowball);
            moveList.Add(move.fireblast);
        }

    }

}
