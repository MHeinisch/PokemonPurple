using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Rival :Trainer
    {

        //member variables



        //constructor
        public Rival()
        {

        }



        //functions
        public void RivalStarterSelectionLogic(List<Pokemon> PlayerPartyList, Pokemon Starter)
        {
            if (PlayerPartyList[0].species.Equals("Bulbasaur"))
            {
                Starter = new Charmander();
            }
            else if (PlayerPartyList[0].species.Equals("Charmander"))
            {
                Starter = new Squirtle();
            }
            else
            {
                Starter = new Bulbasaur();
            }
        }

    }
}
