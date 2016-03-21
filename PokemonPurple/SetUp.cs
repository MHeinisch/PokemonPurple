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
        int userInput = 0;
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
            while (userInput != 1)
            {
                Console.WriteLine("New Game: (1)");
                Int32.TryParse(Console.ReadLine(), out userInput);
                if (userInput != 1)
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
    }
}
