using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Diglett : Pokemon
    {

        //member variables



        //constructor
        public Diglett()
        {
            species = "Diglett";
            typeOneIndex = 9;
            typeTwoIndex = 0;
            moveList.Add(new Tackle());
            moveList.Add(new MudShot());
            /*moveList.Add(new EarthPower());
            moveList.Add(new Earthquake());
            moveList.Add(new PowerGem());*/
        }



        //functions

    }

}
