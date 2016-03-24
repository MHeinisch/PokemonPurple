using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class PrintLine
    {

        //member variables
        public string[] typeArray = new string[19];



        //constructor
        public PrintLine()
        {

        }



        //functions
        public void DisplayGameNameAndRules()
        {
            Console.WriteLine("Welcome to Pokemon Purple!\n");
            Console.WriteLine("Pokemon Purple is a text-based, nuzlocke version of Pokemon.");
            Console.WriteLine("The following is a quick rundown of the nuzlocke rules for any Pokemon game:\n");
            Console.WriteLine("You may only capture the first Pokemon you encounter in each new area. You will not encounter a Pokemon that you've already captured again.");
            Console.WriteLine("Extra Pokemon may be stored in a PC and retrieved for later use.");
            Console.WriteLine("If any of your Pokemon faint in battle, they are lost permanently. Be careful!\n");
        }

        public void DisplayPlayerCreationMessage()
        {
            Console.WriteLine("Hello there! Welcome to the world of POKEMON!");
            Console.WriteLine("My name is OAK! People call me the POKEMON PROF!");
            Console.WriteLine("This world is inhabited by creatures called POKEMON!");
            Console.WriteLine("For some people, Pokemon are pets. Others use them for fights.");
            Console.WriteLine("Myself...");
            Console.WriteLine("I study POKEMON as a profession.");
            Console.WriteLine("First, what is your name?\n");
        }

        public void DisplayRivalCreationMessage()
        {
            Console.WriteLine(" O ");
            Console.WriteLine("-|-");
            Console.WriteLine("/ \\\n");
            Console.WriteLine("^This is my grandson. He's been your rival since you were a baby.");
            Console.WriteLine("...Erm, what is his name again?\n");
        }

        public void EnterGameMessage(Trainer Player)
        {
            Console.WriteLine(Player.name + "! Your very own POKEMON legend is about to unfold!");
            Console.WriteLine("A world of dreams and adventures with POKEMON awaits! Let's go!\n\n\n");
        }

        public void ObtainFirstPokemonMessage(Trainer Player, Trainer Rival)
        {
            Console.WriteLine("OAK: Ahhh " + Player.name + " and " + Rival.name + ", welcome to my lab!");
            Console.WriteLine("     Happy 10th birthday to you both! Enjoy it because you will be 10 for the rest of your life! You are now old enough to get your first POKEMON!");
            Console.WriteLine("     In front of you are three POKEMON!");
            Console.WriteLine("     Haha!");
            Console.WriteLine("     They are inside the POKE BALLs.");
            Console.WriteLine("     When I was young, I was a serious POKEMON trainer!");
            Console.WriteLine("     In my old age, I have only 3 left, but you can have one! Choose!\n");
            Console.WriteLine(Rival.name + ": Hey! Gramps! What about me?\n");
            Console.WriteLine("OAK: Be patient! " + Rival.name + ", you can have one too!\n");
        }

        public string DisplayPokemonTypes(string[] TypeArray, Pokemon pokemon)
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

        public void DisplayPlayerStarterSelectionMessage(string[] TypeArray, Pokemon Starter, Trainer Player)
        {
            Console.WriteLine("\nSo! You want the " + DisplayPokemonTypes(TypeArray, Starter) + " Pokemon, " + Starter.species + "!");                          //normally a question, allow user to say yes/no
            Console.WriteLine("This Pokemon is really energetic!");
            Console.WriteLine(Player.name + " received a " + Starter.species + "!\n\n\n");
        }

        public void DisplayRivalStarterSelectionMessage(string[] TypeArray, Pokemon Starter, Trainer Rival)
        {
            Console.WriteLine(Rival.name + ": I'll take this one then!");
            Console.WriteLine(Rival.name + " received a " + Starter.species + "!\n\n\n");
        }

        public void DisplayInstructionsPostStarterSelection(Trainer Rival)
        {
            Console.WriteLine("From here, you may enter a zone to capture a new Pokemon or train your current Pokemon.");
            Console.WriteLine("Visit the Pokemon Center to heal your party or access the PC.");
            Console.WriteLine("When you feel ready, you may enter the Indigo Plateau to challenge " + Rival.name + ", the current league champion!");
            Console.WriteLine("Remember, if a Pokemon of yours faints in battle, it is lost forever!");
            Console.WriteLine("Good luck out there!\n\n\n\n\n");
        }

        public void DisplayCurrentBattleStats(Pokemon UserPokemon, Pokemon EnemyPokemon)
        {
            DisplayUserPokemonStats(UserPokemon);
            DisplayUserPokemonStats(EnemyPokemon);
        }

        public void DisplayUserPokemonStats(Pokemon UserPokemon)
        {
            Console.WriteLine(UserPokemon.species + ":\t\tLevel: " + UserPokemon.level + "\t\tType: " + DisplayPokemonTypes(typeArray, UserPokemon) + "\t\tHP: " + UserPokemon.currentHealthPoints + "/" + UserPokemon.maxHealthPoints);

        }

        public void DisplayEnemyPokemonStats(Pokemon EnemyPokemon)
        {
            Console.WriteLine(EnemyPokemon.species + ":\t\tLevel: " + EnemyPokemon.level + "\t\tType: " + DisplayPokemonTypes(typeArray, EnemyPokemon) + "\t\tHP: " + EnemyPokemon.currentHealthPoints + "/" + EnemyPokemon.maxHealthPoints);
        }

        public void DisplayBattleOptions(Trainer Player, Zones Zone)
        {
            Console.WriteLine("(A)  Attack");
            if (Player.partyList.Count() > 1)
            {
                Console.WriteLine("(S)  Switch Active Pokemon");
            }
            if (Zone.canCapturePokemon == true && Player.partyList.Count() < 6)
            {
                Console.WriteLine("(T)  Throw Pokeball");
            }
                Console.WriteLine("(R)  Run");
        }

        public string DisplayMoveStats(Moves Move)
        {
            return Move.name + ":\tPower= " + Move.power + "\tAccuracy= " + Move.accuracy + "\tType= " + typeArray[Move.moveTypeIndex];
        }

    }
}