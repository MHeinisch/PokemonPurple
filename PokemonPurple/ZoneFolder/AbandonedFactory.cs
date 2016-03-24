using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class AbandonedFactory : Zones
    {

        //member variables



        //constructor
        public AbandonedFactory()
        {
            zoneName = "Abandoned Factory";
            possiblePokemonList.Add(new Pikachu());
            possiblePokemonList.Add(new Litwick());
            possiblePokemonList.Add(new Klink());
        }



        //functions

    }
}