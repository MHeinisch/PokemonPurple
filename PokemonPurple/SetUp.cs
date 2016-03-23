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
        Trainer player;
        Trainer rival;

        Types type = new Types();
        UI ui = new UI();

        public string[] typeArray = new string[19];
        public double[,] typeMatchup2DArray = new double[19, 19]; //[row, column] row = attack type, column = target types

        public Pokemon bergmite;
        public Pokemon bulbasaur;
        public Pokemon carbink;
        public Pokemon charmander;
        public Pokemon clefairy;
        public Pokemon diglett;
        public Pokemon dratini;
        public Pokemon ekans;
        public Pokemon espurr;
        public Pokemon hawlucha;
        public Pokemon klink;
        public Pokemon litwick;
        public Pokemon meowth;
        public Pokemon noibat;
        public Pokemon pikachu;
        public Pokemon pinsir;
        public Pokemon sableye;
        public Pokemon squirtle;
        public Pokemon starter;

        public Moves tackle = new Moves("Tackle", 50, 100, 35, 1);
        public Moves bodyslam = new Moves("Body Slam", 85, 100, 15, 1);            //can paralyze
        public Moves megakick = new Moves("Mega Kick", 120, 75, 5, 1);
        public Moves ember = new Moves("Ember", 40, 100, 25, 2);                   //can burn
        public Moves flamethrower = new Moves("Flamethrower", 90, 100, 15, 2);     //can burn
        public Moves fireblast = new Moves("Fire Blast", 110, 85, 5, 2);           //can burn
        public Moves watergun = new Moves("Water Gun", 40, 100, 25, 3);
        public Moves surf = new Moves("Surf", 90, 100, 15, 3);
        public Moves hydropump = new Moves("Hydro Pump", 110, 80, 5, 3);
        public Moves thundershock = new Moves("Thunder Shock", 40, 100, 30, 4);    //can paralyze
        public Moves thunderbolt = new Moves("Thunderbolt", 90, 100, 15, 4);       //can paralyze
        public Moves thunder = new Moves("Thunder", 110, 70, 10, 4);               //can paralyze
        public Moves vinewhip = new Moves("Vine Whip", 45, 100, 25, 5);
        public Moves leafblade = new Moves("Leaf Blade", 90, 100, 15, 5);          //high crit chance
        public Moves seedflare = new Moves("Seed Flare", 120, 85, 5, 5);           //can lower target SDef
        public Moves powdersnow = new Moves("Powder Snow", 40, 100, 25, 6);        //can freeze
        public Moves icebeam = new Moves("Ice Beam", 90, 100, 10, 6);              //can freeze
        public Moves blizzard = new Moves("Blizzard", 110, 70, 5, 6);              //can freeze
        public Moves karatechop = new Moves("Karate Chop", 50, 100, 25, 7);        //high crit chance
        public Moves aurasphere = new Moves("Aura Sphere", 80, 100, 20, 7);        //never misses
        public Moves focusblast = new Moves("Focus Blast", 120, 70, 5, 7);         //can lower target SDef
        public Moves acid = new Moves("Acid", 40, 100, 30, 8);                     //can lower target SDef
        public Moves poisonjab = new Moves("Poison Jab", 80, 100, 20, 8);          //can poison
        public Moves gunkshot = new Moves("Gunk Shot", 120, 80, 5, 8);             //can poison
        public Moves mudshot = new Moves("Mud Shot", 55, 95, 15, 9);               //lower target Speed
        public Moves earthpower = new Moves("Earth Power", 90, 100, 10, 9);        //can lower target SDef
        public Moves earthquake = new Moves("Earthquake", 100, 100, 10, 9);
        public Moves gust = new Moves("Gust", 40, 100, 35, 10);
        public Moves drillpeck = new Moves("Drill Peck", 80, 100, 20, 10);
        public Moves hurricane = new Moves("Hurricane", 110, 70, 10, 10);          //can confuse
        public Moves confusion = new Moves("Confusion", 50, 100, 25, 11);          //can confuse
        public Moves psychic = new Moves("Psychic", 90, 100, 10, 11);              //can lower target SDef
        public Moves psychoboost = new Moves("Psycho Boost", 140, 90, 5, 11);      //lower user SAtk
        public Moves strugglebug = new Moves("Struggle Bug", 50, 100, 20, 12);     //lower target SAtk
        public Moves xscissor = new Moves("X-Scissor", 80, 100, 15, 12);
        public Moves megahorn = new Moves("Megahorn", 120, 85, 10, 12);
        public Moves rockthrow = new Moves("Rock Throw", 50, 90, 15, 13);
        public Moves powergem = new Moves("Power Gem", 80, 100, 20, 13);
        public Moves stoneedge = new Moves("Stone Edge", 100, 80, 5, 13);          //high crit chance
        public Moves shadowsneak = new Moves("Shadow Sneak", 40, 100, 30, 14);     //always goes first
        public Moves shadowpunch = new Moves("Shadow Punch", 60, 100, 20, 14);     //never misses
        public Moves shadowball = new Moves("Shadow Ball", 80, 100, 15, 14);       //can lower target SDef
        public Moves twister = new Moves("Twister", 40, 100, 20, 15);              //can flinch
        public Moves dragonpulse = new Moves("Dragon Pulse", 85, 100, 10, 15);
        public Moves dracometeor = new Moves("Draco Meteor", 130, 90, 5, 15);      //lower user SAtk
        public Moves pursuit = new Moves("Pursuit", 40, 100, 20, 16);              //double damage if target switches
        public Moves nightslash = new Moves("Night Slash", 70, 100, 15, 16);       //high crit chance
        public Moves foulplay = new Moves("Foul Play", 95, 100, 15, 16);           //damage calculated from target Atk instead of Def
        public Moves bulletpunch = new Moves("Bullet Punch", 40, 100, 30, 17);     //always goes first
        public Moves flashcannon = new Moves("Flash Cannon", 80, 100, 10, 17);     //can lower target SDef
        public Moves irontail = new Moves("Iron Tail", 100, 75, 15, 17);           //can lower target Def
        public Moves fairywind = new Moves("Fairy Wind", 40, 100, 30, 18);
        public Moves dazzlinggleam = new Moves("Dazzling Gleam", 80, 100, 10, 18);
        public Moves moonblast = new Moves("Moonblast", 95, 100, 15, 18);          //can lower target SAtk



        //constructor
        public SetUp()
        {

        }



        //functions

        public void FillTypeArray()
        {
            typeArray[0] = "";
            typeArray[1] = "Normal";
            typeArray[2] = "Fire";
            typeArray[3] = "Water";
            typeArray[4] = "Electric";
            typeArray[5] = "Grass";
            typeArray[6] = "Ice";
            typeArray[7] = "Fighting";
            typeArray[8] = "Poison";
            typeArray[9] = "Ground";
            typeArray[10] = "Flying";
            typeArray[11] = "Psychic";
            typeArray[12] = "Bug";
            typeArray[13] = "Rock";
            typeArray[14] = "Ghost";
            typeArray[15] = "Dragon";
            typeArray[16] = "Dark";
            typeArray[17] = "Steel";
            typeArray[18] = "Fairy";
        }

        public void FillTypeEffectivenessTwoDArray()
        {
            FillTypeEffectivenessTwoDArrayWithOnes();
            FillTypeEffectivenessTwoDArrayWithMultipliers();
        }

        void FillTypeEffectivenessTwoDArrayWithOnes()
        {
            for (int indexOuterArray = 0; indexOuterArray <= 18; indexOuterArray++)
            {
                for (int indexInnerArray = 0; indexInnerArray <= 18; indexInnerArray++)
                {
                    typeMatchup2DArray[indexOuterArray, indexInnerArray] = 1;
                }
            }
        }

        void FillTypeEffectivenessTwoDArrayWithMultipliers()
        {
            FillTypeMatchupNormalAttack();
            FillTypeMatchupFireAttack();
            FillTypeMatchupWaterAttack();
            FillTypeMatchupElectricAttack();
            FillTypeMatchupGrassAttack();
            FillTypeMatchupIceAttack();
            FillTypeMatchupFightingAttack();
            FillTypeMatchupPoisonAttack();
            FillTypeMatchupGroundAttack();
            FillTypeMatchupFlyingAttack();
            FillTypeMatchupPsychicAttack();
            FillTypeMatchupBugAttack();
            FillTypeMatchupRockAttack();
            FillTypeMatchupGhostAttack();
            FillTypeMatchupDragonAttack();
            FillTypeMatchupDarkAttack();
            FillTypeMatchupSteelAttack();
            FillTypeMatchupFairyAttack();
        }

        void FillTypeMatchupNormalAttack()
        {
            typeMatchup2DArray[1, 13] = .5;
            typeMatchup2DArray[1, 14] = 0;
            typeMatchup2DArray[1, 17] = .5;
        }

        void FillTypeMatchupFireAttack()
        {
            typeMatchup2DArray[2, 2] = .5;
            typeMatchup2DArray[2, 3] = .5;
            typeMatchup2DArray[2, 5] = 2;
            typeMatchup2DArray[2, 6] = 2;
            typeMatchup2DArray[2, 12] = 2;
            typeMatchup2DArray[2, 13] = .5;
            typeMatchup2DArray[2, 15] = .5;
            typeMatchup2DArray[2, 17] = 2;
        }

        void FillTypeMatchupWaterAttack()
        {
            typeMatchup2DArray[3, 2] = 2;
            typeMatchup2DArray[3, 3] = .5;
            typeMatchup2DArray[3, 5] = .5;
            typeMatchup2DArray[3, 9] = 2;
            typeMatchup2DArray[3, 13] = 2;
            typeMatchup2DArray[3, 15] = .5;
        }

        void FillTypeMatchupElectricAttack()
        {
            typeMatchup2DArray[4, 3] = 2;
            typeMatchup2DArray[4, 4] = .5;
            typeMatchup2DArray[4, 5] = .5;
            typeMatchup2DArray[4, 9] = 0;
            typeMatchup2DArray[4, 10] = 2;
            typeMatchup2DArray[4, 15] = .5;
        }

        void FillTypeMatchupGrassAttack()
        {
            typeMatchup2DArray[5, 2] = .5;
            typeMatchup2DArray[5, 3] = 2;
            typeMatchup2DArray[5, 5] = .5;
            typeMatchup2DArray[5, 8] = .5;
            typeMatchup2DArray[5, 9] = 2;
            typeMatchup2DArray[5, 10] = .5;
            typeMatchup2DArray[5, 12] = .5;
            typeMatchup2DArray[5, 13] = 2;
            typeMatchup2DArray[5, 15] = .5;
            typeMatchup2DArray[5, 17] = .5;
        }

        void FillTypeMatchupIceAttack()
        {
            typeMatchup2DArray[6, 2] = .5;
            typeMatchup2DArray[6, 3] = .5;
            typeMatchup2DArray[6, 5] = 2;
            typeMatchup2DArray[6, 6] = .5;
            typeMatchup2DArray[6, 9] = 2;
            typeMatchup2DArray[6, 10] = 2;
            typeMatchup2DArray[6, 15] = 2;
            typeMatchup2DArray[6, 17] = .5;
        }

        void FillTypeMatchupFightingAttack()
        {
            typeMatchup2DArray[7, 1] = 2;
            typeMatchup2DArray[7, 6] = 2;
            typeMatchup2DArray[7, 8] = .5;
            typeMatchup2DArray[7, 10] = .5;
            typeMatchup2DArray[7, 11] = .5;
            typeMatchup2DArray[7, 12] = .5;
            typeMatchup2DArray[7, 13] = 2;
            typeMatchup2DArray[7, 14] = 0;
            typeMatchup2DArray[7, 16] = 2;
            typeMatchup2DArray[7, 17] = 2;
            typeMatchup2DArray[7, 18] = .5;
        }

        void FillTypeMatchupPoisonAttack()
        {
            typeMatchup2DArray[8, 5] = 2;
            typeMatchup2DArray[8, 8] = .5;
            typeMatchup2DArray[8, 9] = .5;
            typeMatchup2DArray[8, 13] = .5;
            typeMatchup2DArray[8, 14] = .5;
            typeMatchup2DArray[8, 17] = 0;
            typeMatchup2DArray[8, 18] = 2;
        }

        void FillTypeMatchupGroundAttack()
        {
            typeMatchup2DArray[9, 2] = 2;
            typeMatchup2DArray[9, 4] = 2;
            typeMatchup2DArray[9, 5] = .5;
            typeMatchup2DArray[9, 8] = 2;
            typeMatchup2DArray[9, 10] = 0;
            typeMatchup2DArray[9, 12] = .5;
            typeMatchup2DArray[9, 13] = 2;
            typeMatchup2DArray[9, 17] = 2;
        }

        void FillTypeMatchupFlyingAttack()
        {
            typeMatchup2DArray[10, 4] = .5;
            typeMatchup2DArray[10, 5] = 2;
            typeMatchup2DArray[10, 7] = 2;
            typeMatchup2DArray[10, 12] = 2;
            typeMatchup2DArray[10, 13] = .5;
            typeMatchup2DArray[10, 17] = .5;
        }

        void FillTypeMatchupPsychicAttack()
        {
            typeMatchup2DArray[11, 7] = 2;
            typeMatchup2DArray[11, 8] = 2;
            typeMatchup2DArray[11, 11] = .5;
            typeMatchup2DArray[11, 16] = 0;
            typeMatchup2DArray[11, 17] = .5;
        }

        void FillTypeMatchupBugAttack()
        {
            typeMatchup2DArray[12, 2] = .5;
            typeMatchup2DArray[12, 5] = 2;
            typeMatchup2DArray[12, 7] = .5;
            typeMatchup2DArray[12, 8] = .5;
            typeMatchup2DArray[12, 10] = .5;
            typeMatchup2DArray[12, 11] = 2;
            typeMatchup2DArray[12, 14] = .5;
            typeMatchup2DArray[12, 16] = 2;
            typeMatchup2DArray[12, 17] = .5;
            typeMatchup2DArray[12, 18] = .5;
        }

        void FillTypeMatchupRockAttack()
        {
            typeMatchup2DArray[13, 2] = 2;
            typeMatchup2DArray[13, 6] = 2;
            typeMatchup2DArray[13, 7] = .5;
            typeMatchup2DArray[13, 9] = .5;
            typeMatchup2DArray[13, 10] = 2;
            typeMatchup2DArray[13, 12] = 2;
            typeMatchup2DArray[13, 17] = .5;
        }

        void FillTypeMatchupGhostAttack()
        {
            typeMatchup2DArray[14, 1] = 0;
            typeMatchup2DArray[14, 11] = 2;
            typeMatchup2DArray[14, 14] = 2;
            typeMatchup2DArray[14, 16] = .5;
        }

        void FillTypeMatchupDragonAttack()
        {
            typeMatchup2DArray[15, 15] = 2;
            typeMatchup2DArray[15, 17] = .5;
            typeMatchup2DArray[15, 18] = 0;
        }

        void FillTypeMatchupDarkAttack()
        {
            typeMatchup2DArray[16, 7] = .5;
            typeMatchup2DArray[16, 11] = 2;
            typeMatchup2DArray[16, 14] = 2;
            typeMatchup2DArray[16, 16] = .5;
            typeMatchup2DArray[16, 18] = .5;
        }

        void FillTypeMatchupSteelAttack()
        {
            typeMatchup2DArray[17, 2] = .5;
            typeMatchup2DArray[17, 3] = .5;
            typeMatchup2DArray[17, 4] = .5;
            typeMatchup2DArray[17, 6] = 2;
            typeMatchup2DArray[17, 13] = 2;
            typeMatchup2DArray[17, 17] = .5;
            typeMatchup2DArray[17, 18] = 2;
        }

        void FillTypeMatchupFairyAttack()
        {
            typeMatchup2DArray[18, 2] = .5;
            typeMatchup2DArray[18, 7] = 2;
            typeMatchup2DArray[18, 8] = .5;
            typeMatchup2DArray[18, 15] = 2;
            typeMatchup2DArray[18, 16] = 2;
            typeMatchup2DArray[18, 17] = .5;
        }
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
            while (ui.userInputGameSelection != 1)
            {
                Console.WriteLine("New Game: (1)");
                Int32.TryParse(Console.ReadLine(), out ui.userInputGameSelection);
                if (ui.userInputGameSelection != 1)
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

            player = new Player();
            player.name = Console.ReadLine(); ;

            Console.WriteLine("Right! So your name is " + player.name + "!\n");
            Console.WriteLine(" O ");
            Console.WriteLine("-|-");
            Console.WriteLine("/ \\\n");
            Console.WriteLine("^This is my grandson. He's been your rival since you were a baby.");
            Console.WriteLine("...Erm, what is his name again?\n");

            rival = new Rival();
            rival.name = Console.ReadLine();

            Console.WriteLine("That's right! I remember now! His name is " + rival.name + "!\n");

            Console.WriteLine(player.name + "! Your very own POKEMON legend is about to unfold!");
            Console.WriteLine("A world of dreams and adventures with POKEMON awaits! Let's go!");
       }

        public void PlayerObtainFirstPokemon()
        {
            Console.WriteLine("OAK: Ahhh " + player.name + " and " + rival.name + ", welcome to my lab!");
            Console.WriteLine("\tHappy 10th birthday to you both! Enjoy it because you will be 10 for the rest of your life! You are now old enough to get your first POKEMON!");
            Console.WriteLine("\tIn front of you are three POKEMON!");
            Console.WriteLine("\tHaha!");
            Console.WriteLine("\tThey are inside the POKE BALLs.");
            Console.WriteLine("\tWhen I was young, I was a serious POKEMON trainer!");
            Console.WriteLine("In my old age, I have only 3 left, but you can have one! Choose!\n");
            Console.WriteLine(rival.name + ": Hey! Gramps! What about me?\n");
            Console.WriteLine("OAK: Be patient! " + rival.name + ", you can have one too!\n");



            while (ui.userInputPokemonSelection != 1 && ui.userInputPokemonSelection != 2 && ui.userInputPokemonSelection != 3)
            {
                Console.WriteLine("BULBASAUR, the Grass/Poison POKEMON!     (1)");
                Console.WriteLine("CHARMANDER, the Fire POKEMON!            (2)");
                Console.WriteLine("SQUIRTLE, the Water POKEMON!             (3)");

                Int32.TryParse(Console.ReadLine(), out ui.userInputPokemonSelection);
                if (ui.userInputPokemonSelection != 1 && ui.userInputPokemonSelection != 2 && ui.userInputPokemonSelection != 3)
                {
                    Console.WriteLine("Oops! Invalid entry, please try again.\n");
                }
            }
            string printTypes;
            if (ui.userInputPokemonSelection == 1)
            {
                starter = new Bulbasaur();
            }
            else if(ui.userInputPokemonSelection == 2)
            {
                starter = new Charmander();
            }
            else if (ui.userInputPokemonSelection == 3)
            {
                starter = new Squirtle();
            }

            Console.WriteLine("\n\n\n");
            printTypes = type.PrintPokemonTypes(typeArray, starter);
            Console.WriteLine("So! You want the " + printTypes + " Pokemon, " + starter.species + "!");                          //normally a question, allow user to say yes/no
            Console.WriteLine("This Pokemon is really energetic!");
            Console.WriteLine(player.name + " received a " + starter.species + "!\n\n\n");
            //Console.WriteLine("Do you want to give a nickname to " + starter.species + "?");                                                //user input again yo
            player.partyList.Add(starter);

        }

        public void RivalObtainFirstPokemon()
        {
            if(player.partyList[0].species.Equals("Bulbasaur"))
            {
                starter = new Charmander();
            }
            else if(player.partyList[0].species.Equals("Charmander"))
            {
                starter = new Squirtle();
            }
            else
            {
                starter = new Bulbasaur();
            }
            rival.partyList.Add(starter);
            Console.WriteLine(rival.name + ": I'll take this one, then!");
            Console.WriteLine(rival.name + " received a " + starter.species + "!");
        }

        //initiate first battle? (you should probably always win)

    }
}
