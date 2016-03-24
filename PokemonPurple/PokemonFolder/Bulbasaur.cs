using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Bulbasaur : Pokemon
    {

        //member variables


 
        //constructor
        public Bulbasaur()
        {
            species = "Bulbasaur";
            typeOneIndex = 5;
            typeTwoIndex = 8;
            moveList.Add(new Tackle());
            moveList.Add(new VineWhip());
            moveList.Add(new Acid());
            /*moveList.Add(new LeafBlade());
            moveList.Add(new PoisonJab());
            moveList.Add(new SeedFlare());
            moveList.Add(new GunkShot());*/
        }



        //functions

    }

}
