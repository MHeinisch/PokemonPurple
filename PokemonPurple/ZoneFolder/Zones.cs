using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Zones
    {

        //member variables
        public string zoneName;

        public List<Pokemon> possiblePokemonList = new List<Pokemon>();

        public bool canCapturePokemon = true;



        //constructor
        public Zones()
        {

        }



        //functions
        protected virtual void GeneratePossiblePokemonList()
        {

        }

    }
}
