using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Litwick : Pokemon
    {

        //member variables



        //constructor
        public Litwick()
        {
            species = "Litwick";
            typeOneIndex = 14;
            typeTwoIndex = 2;
            moveList.Add(new Tackle());
            moveList.Add(new ShadowSneak());
            moveList.Add(new Ember());
            moveList.Add(new ShadowPunch());
            moveList.Add(new Flamethrower());
            moveList.Add(new ShadowBall());
            moveList.Add(new FireBlast());
        }



        //functions

    }

}
