using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class UI
    {

        //member variables
        public int userInputGameSelection = 0;
        public int userInputPokemonSelection = 0;
        public int userInputZoneSelection = 0;



        //constructor
        public UI()
        {

        }



        //functions
        /*public void SelectNewOrSavedGame()
        {
            Console.WriteLine("Please select a game option:\n");
            while (userInputGameSelection != 1)
            {
                Console.WriteLine("New Game: (1)");
                Int32.TryParse(Console.ReadLine(), out userInputGameSelection);
                if (userInputGameSelection != 1)
                {
                    Console.WriteLine("Oops! Invalid entry, please try again.\n");
                }
            }
        }*/

        public string GetUserInputName()
        {
            string uiName = Console.ReadLine();
            return uiName;
        }

        public int GetUserInputStarterPokemonSelection()
        {
            while (userInputPokemonSelection != 1 && userInputPokemonSelection != 2 && userInputPokemonSelection != 3)
            {
                Console.WriteLine("BULBASAUR, the Grass/Poison POKEMON!     (1)");
                Console.WriteLine("CHARMANDER, the Fire POKEMON!            (2)");
                Console.WriteLine("SQUIRTLE, the Water POKEMON!             (3)");
                Int32.TryParse(Console.ReadLine(), out userInputPokemonSelection);
                if (userInputPokemonSelection != 1 && userInputPokemonSelection != 2 && userInputPokemonSelection != 3)
                {
                    Console.WriteLine("Oops! Invalid entry, please try again.\n");
                }
            }
            return userInputPokemonSelection;
        }

        public int GetUserInputZoneSelection(List<Zones> ZoneList)
        {
            while (userInputZoneSelection < 1 || userInputZoneSelection > ZoneList.Count())
            {
                for (int zoneListIndex = 0; zoneListIndex < ZoneList.Count(); zoneListIndex++)
                {
                    Console.WriteLine("(" + (zoneListIndex + 1) + "):    " + ZoneList[zoneListIndex].zoneName);
                }
                Int32.TryParse(Console.ReadLine(), out userInputZoneSelection);
            }
            return userInputZoneSelection;
        }

    }
}
