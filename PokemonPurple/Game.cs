using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Game
    {

        //member variables
        public Trainer player;
        public Trainer rival;
        public Pokemon starter;

        UI ui = new UI();
        PrintLine print = new PrintLine();
        Types type = new Types();
        Zones zone = new Zones();

        public double[,] typeMatchup2DArray = new double[19, 19]; //[row, column] row = attack type, column = target types
        
        List<Zones> zoneList = new List<Zones>();

        int zoneChoiceInt;
        int activePokemonIndex = 0;



        //constructor
        public Game()
        {
            zoneList.Add(new PokeCenter());
            zoneList.Add(new Route1());
            zoneList.Add(new Mountain());
            zoneList.Add(new Rainforest());
            zoneList.Add(new AbandonedFactory());
            zoneList.Add(new AlternateDimension());
            zoneList.Add(new IndigoPlateau());
        }



        //functions
        public void SetUpGame()
        {
            GenerateTypeArrays();
            print.DisplayGameNameAndRules();
            //ui.SelectNewOrSavedGame();                                            //only create if new game, otherwise load
            CreatePlayer();
            CreateRival();
            print.EnterGameMessage(player);
            PlayerObtainFirstPokemon();
            RivalObtainFirstPokemon();
            print.DisplayInstructionsPostStarterSelection(rival);
        }

        public void GenerateTypeArrays()
        {
            FillTypeArray();
            FillTypeEffectivenessTwoDArray();
        }
        public void FillTypeArray()
        {
            print.typeArray[0] = "";
            print.typeArray[1] = "Normal";
            print.typeArray[2] = "Fire";
            print.typeArray[3] = "Water";
            print.typeArray[4] = "Electric";
            print.typeArray[5] = "Grass";
            print.typeArray[6] = "Ice";
            print.typeArray[7] = "Fighting";
            print.typeArray[8] = "Poison";
            print.typeArray[9] = "Ground";
            print.typeArray[10] = "Flying";
            print.typeArray[11] = "Psychic";
            print.typeArray[12] = "Bug";
            print.typeArray[13] = "Rock";
            print.typeArray[14] = "Ghost";
            print.typeArray[15] = "Dragon";
            print.typeArray[16] = "Dark";
            print.typeArray[17] = "Steel";
            print.typeArray[18] = "Fairy";
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

        public void CreatePlayer()
        {
            print.DisplayPlayerCreationMessage();
            player = new Player();
            player.name = ui.GetUserInputName();
            Console.WriteLine("Right! So your name is " + player.name + "!\n");
        }

        public void CreateRival()
        {
            print.DisplayRivalCreationMessage();
            rival = new Rival();
            rival.name = ui.GetUserInputName();
            Console.WriteLine("That's right! I remember now! His name is " + rival.name + "!\n\n\n");
        }

        public void PlayerObtainFirstPokemon()
        {
            print.ObtainFirstPokemonMessage(player, rival);
            int starterChoiceInt = ui.GetUserInputStarterPokemonSelection();
            starter = new Pokemon();
            starter.GeneratePlayerStarterPokemon(starterChoiceInt, player);
            print.DisplayPlayerStarterSelectionMessage(print.typeArray, player.partyList[0], player);
            //Console.WriteLine("Do you want to give a nickname to " + starter.species + "?");                                                //user input again yo
        }

        public void RivalObtainFirstPokemon()
        {
            starter = new Pokemon();
            starter.GenerateRivalStarterPokemon(player.partyList, starter, rival);
            //rival.RivalStarterSelectionLogic();
            print.DisplayRivalStarterSelectionMessage(print.typeArray, rival.partyList[0], rival);
        }

        public void PlayGame()
        {
            SelectZone();
            if (zoneChoiceInt == 1 || zoneChoiceInt > zoneList.Count() - 1)
            {
                Console.WriteLine("Do PokeCenter Options/Challenge Rival");
            }
            else
            {
                EnterWildBattle(zoneList[zoneChoiceInt - 1]);
            }
        }

        public void SelectZone()
        {
            Console.WriteLine("Please select a Zone to enter:");
            zoneChoiceInt = ui.GetUserInputZoneSelection(zoneList);
            Console.WriteLine("\nYou are traveling to " + zoneList[zoneChoiceInt - 1].zoneName);
        }

        public void EnterWildBattle(Zones Zone)
        {
            Random randomInt = new Random();
            int possiblePokemonListIndex = randomInt.Next(0, Zone.possiblePokemonList.Count());
            Console.WriteLine("You've encountered a wild " + Zone.possiblePokemonList[possiblePokemonListIndex].species + "!");
            Pokemon Wild = Zone.possiblePokemonList[possiblePokemonListIndex];
            Wild.level = player.partyList[0].level - 1;
            Wild.maxHealthPoints = Wild.level * 5;
            Wild.currentHealthPoints = Wild.maxHealthPoints;
            print.DisplayEnemyPokemonStats(Wild);
            Console.WriteLine("\nWhich Pokemon would you like to use?");
            if (player.partyList.Count() > 1)
            {
                for (int partyListIndex = 0; partyListIndex < player.partyList.Count(); partyListIndex++)
                {
                    Console.WriteLine("(" + (partyListIndex + 1) + ") " + player.partyList[partyListIndex].species);
                }
                activePokemonIndex = (ui.GetUserInputActivePokemonSelection(player) - 1);
            }
            Console.WriteLine("Go " + player.partyList[activePokemonIndex].species + "!");
        }

        public void Battle()
        {
            print.DisplayBattleOptions(player, zoneList[zoneChoiceInt]);
            string battleChoiceString = ui.GetUserInputBattleSelection();
            if (battleChoiceString.ToUpper().Equals("A"))
            {
                for (int movesListIndex = 0; movesListIndex < player.partyList[activePokemonIndex].moveList.Count(); movesListIndex++)
                {
                    string currentMoveInfo = print.DisplayMoveStats(player.partyList[activePokemonIndex].moveList[movesListIndex]);
                    Console.WriteLine("(" + (movesListIndex + 1) + ") " + currentMoveInfo);
                }
                //attack stuff
            }
            else if (battleChoiceString.ToUpper().Equals("S"))
            {
                //switch pokemon stuff
            }
            else if (battleChoiceString.ToUpper().Equals("T"))
            {
                //catch stuff
            }
            else if (battleChoiceString.ToUpper().Equals("R"))
            {
                //return to zone selection brah
            }
        }

    public void CheckForWinOrLoss(Pokemon UserPokemon, Pokemon EnemyPokemon)
        {
            if(EnemyPokemon.currentHealthPoints <= 0)
            {
                UserPokemon.LevelUp();
            }
            else if(UserPokemon.currentHealthPoints <= 0)
            {
                player.partyList.Remove(UserPokemon);
            }
        }

    }
}
