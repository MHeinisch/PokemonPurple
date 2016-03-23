using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Program
    {
        static void Main(string[] args)
        {

            SetUp setup = new SetUp();

            setup.FillTypeArray();
            setup.FillTypeEffectivenessTwoDArray();

            setup.DisplayIntroMessasges();

            setup.SelectNewOrSavedGame();

            setup.CreatePlayerAndRival();

            setup.ObtainFirstPokemon();

            Console.ReadLine();

        }
    }
}
