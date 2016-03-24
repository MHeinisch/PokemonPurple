using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Klink : Pokemon
    {

        //member variables



        //constructor
        public Klink()
        {
            species = "Klink";
            typeOneIndex = 17;
            typeTwoIndex = 0;
            moveList.Add(new Tackle());
            moveList.Add(new BulletPunch());
            /*moveList.Add(new FlashCannon());
            moveList.Add(new IronTail());
            moveList.Add(new Thunderbolt());*/
        }



        //functions

    }

}
