using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Bulbasaur : Pokemon
    {

        //member variables


 
        //constructor
        public Bulbasaur()
        {
            species = "Bulbasaur";
            typeOneIndex = 5;
            typeTwoIndex = 8;
        }



        //functions
        protected override void GenerateMoveList()
        {
            moveList.Add(move.tackle);
            moveList.Add(move.vinewhip);
            moveList.Add(move.acid);
            moveList.Add(move.leafblade);
            moveList.Add(move.poisonjab);
            moveList.Add(move.seedflare);
            moveList.Add(move.gunkshot);
        }

    }

}
