using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Pinsir : Pikachu
    {

        //member variables



        //constructor
        public Pinsir()
        {
            species = "Pinsir";
            typeOneIndex = 12;
            typeTwoIndex = 0;
        }



        //functions
        protected override void GenerateMoveList()
        {
            moveList.Add(move.tackle);
            moveList.Add(move.strugglebug);
            moveList.Add(move.xscissor);
            moveList.Add(move.megahorn);
            moveList.Add(move.aurasphere);
        }

    }

}
