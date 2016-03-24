using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Ekans : Pokemon
    {

        //member variables



        //constructor
        public Ekans()
        {
            species = "Ekans";
            typeOneIndex = 8;
            typeTwoIndex = 0;
            moveList.Add(new Tackle());
            moveList.Add(new Acid());
            /*moveList.Add(new PoisonJab());
            moveList.Add(new GunkShot());
            moveList.Add(new EarthPower());*/
        }



        //functions

    }

}
