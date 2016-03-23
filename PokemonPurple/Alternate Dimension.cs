using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Alternate_Dimension : Zones
    {

        //member variables



        //constructor
        public Alternate_Dimension()
        {
            zoneName = "Alternate Dimension";
        }



        //functions
        protected override void GeneratePossiblePokemonList()
        {
            possiblePokemonList.Add(pokemon.espurr);
            possiblePokemonList.Add(pokemon.sableye);
            possiblePokemonList.Add(pokemon.dratini);
        }

    }
}
