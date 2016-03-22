using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class SetUp
    {

        //member variables
        int userInputGameSelection = 0;
        int userInputPokemonSelection = 0;
        string playerName;
        string rivalName;



        //constructor
        public SetUp()
        {

        }



        //functions
            //intro messages
        public void DisplayIntroMessasges()
        {
            Console.WriteLine("Welcome to Pokemon Purple!\n");
            Console.WriteLine("Pokemon Purple is a text-based, nuzlocke version of the original Gen 1 Pokemon games.");
            Console.WriteLine("The following is a quick rundown of the nuzlocke rules for any Pokemon game:\n");
            Console.WriteLine("You may only capture the first Pokemon you encounter in each new area. You will not encounter a Pokemon that you've already captured again.");
            Console.WriteLine("If any of your Pokemon faint in battle, they are lost permanently. Be careful!");
            Console.WriteLine("Extra Pokemon may be stored in a PC and retrieved for later use.\n");
        }

        public void SelectNewOrSavedGame()
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
        }

        public void CreatePlayerAndRival()
        {
            Console.WriteLine("Hello there! Welcome to the world of POKEMON!");
            Console.WriteLine("My name is OAK! People call me the POKEMON PROF!");
            Console.WriteLine("This world is inhabited by creatures called POKEMON!");
            Console.WriteLine("For some people, Pokemon are pets. Others use them for fights.");
            Console.WriteLine("Myself...");
            Console.WriteLine("I study POKEMON as a profession.");
            Console.WriteLine("First, what is your name?\n");

            Trainer player = new Trainer(playerName = Console.ReadLine());

            Console.WriteLine("Right! So your name is " + playerName + "!\n");
            Console.WriteLine(" O ");
            Console.WriteLine("-|-");
            Console.WriteLine("/ \\\n");
            Console.WriteLine("^This is my grandson. He's been your rival since you were a baby.");
            Console.WriteLine("...Erm, what is his name again?\n");

            Trainer rival = new Trainer(rivalName = Console.ReadLine());

            Console.WriteLine("That's right! I remember now! His name is " + rivalName + "!\n");

            Console.WriteLine(playerName + "! Your very own POKEMON legend is about to unfold!");
            Console.WriteLine("A world of dreams and adventures with POKEMON awaits! Let's go!");
       }

        public void ObtainFirstPokemon()
        {
            Console.WriteLine("OAK: Ahhh " + playerName + " and " + rivalName + ", welcome to my lab!");
            Console.WriteLine("\tHappy 10th birthday to you both! Enjoy it because you will be 10 for the rest of your life! You are now old enough to get your first POKEMON!");
            Console.WriteLine("\tIn front of you are three POKEMON!");
            Console.WriteLine("\tHaha!");
            Console.WriteLine("\tThey are inside the POKE BALLs.");
            Console.WriteLine("\tWhen I was young, I was a serious POKEMON trainer!");
            Console.WriteLine("In my old age, I have only 3 left, but you can have one! Choose!\n");
            Console.WriteLine(rivalName + ": Hey! Gramps! What about me?\n");
            Console.WriteLine("OAK: Be patient! " + rivalName + ", you can have one too!\n");



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
                if (userInputPokemonSelection == 1)
                {
                    Pokemon Bulbasaur = new Pokemon("Bulbasaur", 5, 5, 8);
                    Console.WriteLine("Congratulations,  you selected BULBASAUR!!!! fix me");
                }
                else if(userInputPokemonSelection == 2)
                {
                    Pokemon Charmander = new Pokemon("Charmander", 5, 2, 0);
                    Console.WriteLine("Congratulations,  you selected CHARMANDER!!!! fix me");
                }
                else if (userInputPokemonSelection == 3)
                {
                    Pokemon Squirtle = new Pokemon("Squirtle", 5, 3, 0);
                    Console.WriteLine("Congratulations,  you selected SQUIRTLE!!!! fix me");
                }
            //blahblahblah oak says pick a pokemon
            //see description of each pkmn
            //if else select with pkmn
            //rival selects pkmn stronger than yours
            //initiate first battle? (you should probably always win)
        }

    }
}
