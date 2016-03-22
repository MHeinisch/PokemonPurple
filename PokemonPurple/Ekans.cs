﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Ekans : Pokemon
    {

        //member variables



        //constructor
        public Ekans()
        {
            species = "Ekans";
            typeOneIndex = 8;
            typeTwoIndex = 0;
        }



        //functions
        protected override void GenerateMoveList()
        {
            moveList.Add(move.tackle);
            moveList.Add(move.acid);
            moveList.Add(move.poisonjab);
            moveList.Add(move.gunkshot);
            moveList.Add(move.earthpower);
        }

    }

}
