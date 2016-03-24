using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Charmander :  Pokemon
    {

        //member variables



        //constructor
        public Charmander()
        {
            species = "Charmander";
            typeOneIndex = 2;
            typeTwoIndex = 0;
            moveList.Add(new Tackle());
            moveList.Add(new Ember());
            /*moveList.Add(new Flamethrower());     //can burn
            moveList.Add(new FireBlast());
            moveList.Add(new DragonPulse());*/
        }



        //functions

    }

}
