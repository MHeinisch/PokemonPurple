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
            possiblePokemonList.Add(new Pikachu());
            possiblePokemonList.Add(new Litwick());
            possiblePokemonList.Add(new Klink());
        }

    }
}