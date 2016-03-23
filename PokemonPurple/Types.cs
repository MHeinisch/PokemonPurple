using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Types
    {

        //member variables
        int attackTypeIndex;



        //constructor
        public Types()
        {

        }



        //functions
        public string PrintPokemonTypes(string[] TypeArray, Pokemon pokemon)
        {
            string typesPrintStatement;
            if (pokemon.typeTwoIndex == 0)
            {
                typesPrintStatement = TypeArray[pokemon.typeOneIndex];
            }
            else
            {
                typesPrintStatement = TypeArray[pokemon.typeOneIndex] + "/" + TypeArray[pokemon.typeTwoIndex];
            }
            return typesPrintStatement;
        }

        void CalculateTypeMultiplier()
        {

        }

        void CalculateSTAB()
        {

        }

    }
}