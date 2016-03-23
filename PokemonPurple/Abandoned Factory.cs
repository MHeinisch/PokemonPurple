using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Abandoned_Factory : Zones
    {

        //member variables



        //constructor
        public Abandoned_Factory()
        {
            zoneName = "Abandoned Factory";
        }



        //functions
        protected override void GeneratePossiblePokemonList()
        {
            possiblePokemonList.Add(pokemon.pikachu);
            possiblePokemonList.Add(pokemon.litwick);
            possiblePokemonList.Add(pokemon.klink);
        }

    }
}