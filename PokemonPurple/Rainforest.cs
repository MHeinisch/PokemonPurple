﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Rainforest : Zones
    {

        //member variables



        //constructor
        public Rainforest()
        {
            zoneName = "Rainforest";
        }



        //functions
        protected override void GeneratePossiblePokemonList()
        {
            possiblePokemonList.Add(new Pinsir());
            possiblePokemonList.Add(new Ekans());
            possiblePokemonList.Add(new Noibat());
        }

    }
}
