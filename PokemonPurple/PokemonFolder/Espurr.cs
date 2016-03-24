using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Espurr : Pokemon
    {

        //member variables



        //constructor
        public Espurr()
        {
            species = "Espurr";
            typeOneIndex = 11;
            typeTwoIndex = 0;
            moveList.Add(new Tackle());
            moveList.Add(new Confusion());
            /*moveList.Add(new Psychic());
            moveList.Add(new PsychoBoost());
            moveList.Add(new DazzlingGleam());*/
        }



        //functions

    }

}
