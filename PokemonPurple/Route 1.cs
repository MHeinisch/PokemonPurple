using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Route_1 : Zones
    {

        //member variables



        //constructor
        public Route_1()
        {
            zoneName = "Route 1";
        }



        //functions
        protected override void GeneratePossiblePokemonList()
        {
            possiblePokemonList.Add(new Meowth());
            possiblePokemonList.Add(new Hawlucha());
            possiblePokemonList.Add(new Clefairy());
        }

    }
}
