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
        protected SetUp pokemon = new SetUp();

        public string zoneName;

        protected List<Pokemon> possiblePokemonList = new List<Pokemon>();



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
