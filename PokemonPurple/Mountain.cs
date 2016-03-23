using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Mountain : Zones
    {

        //member variables



        //constructor
        public Mountain()
        {
            zoneName = "Mountain";
        }



        //functions
        protected override void GeneratePossiblePokemonList()
        {
            possiblePokemonList.Add(pokemon.bergmite);
            possiblePokemonList.Add(pokemon.diglett);
            possiblePokemonList.Add(pokemon.carbink);
        }

    }
}
