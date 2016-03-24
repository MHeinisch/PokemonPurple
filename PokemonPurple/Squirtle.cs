using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Squirtle : Pokemon
    {

        //member variables



        //constructor
        public Squirtle()
        {
            species = "Squirtle";
            typeOneIndex = 3;
            typeTwoIndex = 0;
            moveList.Add(new Tackle());
            moveList.Add(new WaterGun());
            moveList.Add(new Surf());
            moveList.Add(new HydroPump());
            moveList.Add(new IceBeam());
        }



        //functions

    }

}
