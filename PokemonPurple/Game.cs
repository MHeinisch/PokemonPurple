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
        public Pokemon wild;

        UI ui = new UI();
        PrintLine print = new PrintLine();
        Types type = new Types();
        Zones zone = new Zones();

        public double[,] typeMatchup2DArray = new double[19, 19]; //[row, column] row = attack type, column = target types
        
        List<Zones> zoneList = new List<Zones>();

        int zoneChoiceInt;
        int activePokemonIndex = 0;
        int attackSelectionIndex;

        string battleChoiceString = " ";

        bool inBattle = false;
        bool inRivalBattle = false;



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
            print.DisplayRivalStarterSelectionMessage(print.typeArray, rival.partyList[0], rival);
        }

        public void PlayGame()
        {
            while (inRivalBattle == false)                                                                                                                //what condition to keep playing?
            {
                SelectZone();
                if (zoneChoiceInt == 1)
                {
                    Console.WriteLine("The Poke Center is currently under construction and unavailable at this time. Please visit again later!");
                }
                else if(zoneChoiceInt == zoneList.Count())
                {
                    inRivalBattle = true;
                    Console.WriteLine("The current league champion is in a meeting, please try again later!");
                }
                else
                {
                    EnterWildBattle(zoneList[zoneChoiceInt - 1]);
                    Battle();
                }
            }
        }

        public void SelectZone()
        {
            inBattle = true;
            Console.WriteLine("Please select a Zone to enter:");
            zoneChoiceInt = ui.GetUserInputZoneSelection(zoneList);
            Console.WriteLine("\nYou are traveling to " + zoneList[zoneChoiceInt - 1].zoneName);
        }

        public void EnterWildBattle(Zones Zone)
        {
            Random randomInt = new Random();
            int possiblePokemonListIndex = randomInt.Next(0, Zone.possiblePokemonList.Count());
            Console.WriteLine("You've encountered a wild " + Zone.possiblePokemonList[possiblePokemonListIndex].species + "!");
            wild = Zone.possiblePokemonList[possiblePokemonListIndex];
            wild.level = player.partyList[0].level - 1;
            wild.maxHealthPoints = wild.level * 5;
            wild.currentHealthPoints = wild.maxHealthPoints;
            print.DisplayEnemyPokemonStats(wild);
            if (player.partyList.Count() > 1)
            {
                Console.WriteLine("\nWhich Pokemon would you like to use?");
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
            while (inBattle == true && player.partyList.Count() > 0)
            {
                print.DisplayBattleOptions(player, zoneList[zoneChoiceInt]);
                battleChoiceString = ui.GetUserInputBattleSelection();
                if (battleChoiceString.ToUpper().Equals("A"))
                {
                    Console.WriteLine(player.partyList[activePokemonIndex].species + "'s turn!");
                    for (int movesListIndex = 0; movesListIndex < player.partyList[activePokemonIndex].moveList.Count(); movesListIndex++)
                    {
                        string currentMoveInfo = print.DisplayMoveStats(player.partyList[activePokemonIndex].moveList[movesListIndex]);
                        Console.WriteLine("(" + (movesListIndex + 1) + ") " + currentMoveInfo);
                    }
                    attackSelectionIndex = ui.GetUserInputAttackSelection(player, activePokemonIndex) - 1;
                    CalculateDamage(player.partyList[activePokemonIndex], wild, attackSelectionIndex);
                    attackSelectionIndex = -1;
                    CheckForWinOrLoss(player.partyList[activePokemonIndex], wild);
                    if (inBattle == true)
                    {
                        Console.WriteLine(wild.species + "'s turn!");
                        Random rnd = new Random();
                        int enemyAttackIndex = rnd.Next(0, wild.moveList.Count() - 1);
                        CalculateDamage(wild, player.partyList[activePokemonIndex], enemyAttackIndex);
                        CheckForWinOrLoss(player.partyList[activePokemonIndex], wild);
                    }
                    if(player.partyList[activePokemonIndex].currentHealthPoints > 0 && wild.currentHealthPoints > 0)
                    {
                        print.DisplayCurrentBattleStats(player.partyList[activePokemonIndex], wild);
                    }
                }
                else if (battleChoiceString.ToUpper().Equals("S"))
                {
                    if (player.partyList.Count() > 1)
                    {
                        Console.WriteLine("\nWhich Pokemon would you like to use?");
                        for (int partyListIndex = 0; partyListIndex < player.partyList.Count(); partyListIndex++)
                        {
                            Console.WriteLine("(" + (partyListIndex + 1) + ") " + player.partyList[partyListIndex].species);
                        }
                        activePokemonIndex = (ui.GetUserInputActivePokemonSelection(player) - 1);
                    }
                    Console.WriteLine("Go " + player.partyList[activePokemonIndex].species + "!");
                    //switch pokemon stuff
                }
                else if (battleChoiceString.ToUpper().Equals("T"))
                {
                    Random catchChance = new Random();
                    int chanceToCatch = catchChance.Next(1, 11);

                    Console.WriteLine("You threw a Poke Ball at " + wild.species + "!");
                    Console.WriteLine("*wiggle*");
                    Console.WriteLine("*wiggle*");
                    Console.WriteLine("...*wiggle*...");
                    if (wild.currentHealthPoints < wild.maxHealthPoints / 2)
                    {
                        chanceToCatch += 3;
                    }
                    if (chanceToCatch >= 6)
                    {
                        Random rivalPokemon = new Random();
                        int rivalPokemonToAddIndex = rivalPokemon.Next(0, 3);
                        Console.WriteLine("Congratulations, you caught " + wild.species + "!");
                        wild.currentHealthPoints = wild.maxHealthPoints;
                        player.partyList.Add(wild);
                        rival.partyList.Add(zoneList[zoneChoiceInt].possiblePokemonList[rivalPokemonToAddIndex]);
                        player.partyList[activePokemonIndex].currentHealthPoints = player.partyList[activePokemonIndex].maxHealthPoints;
                    }
                    else
                    {
                        Console.WriteLine("Oh no, " + wild.species + " got away! Better luck next time!");
                        player.partyList[activePokemonIndex].currentHealthPoints = player.partyList[activePokemonIndex].maxHealthPoints;
                    }
                    zoneList[zoneChoiceInt].canCapturePokemon = false;
                    inBattle = false;
                    //catch stuff
                }
                else if (battleChoiceString.ToUpper().Equals("R"))
                {
                    Console.WriteLine("You got away!");
                    inBattle = false;
                    zoneList[zoneChoiceInt].canCapturePokemon = false;
                }
            }
        }

    public void CheckForWinOrLoss(Pokemon UserPokemon, Pokemon EnemyPokemon)
        {
            if(EnemyPokemon.currentHealthPoints <= 0)
            {
                Console.WriteLine("\n" + UserPokemon.species + " has defeated " + EnemyPokemon.species + "!");
                UserPokemon.LevelUp(UserPokemon);
                UserPokemon.currentHealthPoints = UserPokemon.maxHealthPoints;
                inBattle = false;
                zoneList[zoneChoiceInt].canCapturePokemon = false;
            }
            else if(UserPokemon.currentHealthPoints <= 0)
            {
                Console.WriteLine("\nYou have been defeated!");
                Console.WriteLine(UserPokemon.species + " has been taken to the Pokemon Tower in Lavender Town...");
                player.partyList.Remove(UserPokemon);
                inBattle = false;
                zoneList[zoneChoiceInt].canCapturePokemon = false;
                if (player.partyList.Count() == 0)
                {
                    inRivalBattle = true;
                    Console.WriteLine("Oh no, you're out of Pokemon! " + player.name + " blacked out...");
                }
            }
        }

        public void CalculateDamage(Pokemon AttackingPokemon, Pokemon DefendingPokemon, int MovesListIndex)
        {
            int baseDamage;
            double typeMultiplier;
            double totalDamage;
            Random rnd = new Random();
            int rndUserLevel = rnd.Next(0, AttackingPokemon.level + 1);
            int rndEnemyLevel = rnd.Next(0, DefendingPokemon.level + 1);
            baseDamage = (player.partyList[activePokemonIndex].moveList[MovesListIndex].power + (rndUserLevel - rndEnemyLevel)) / 5;
            typeMultiplier = typeMatchup2DArray[AttackingPokemon.moveList[MovesListIndex].moveTypeIndex, DefendingPokemon.typeOneIndex] * typeMatchup2DArray[AttackingPokemon.moveList[MovesListIndex].moveTypeIndex, DefendingPokemon.typeTwoIndex];
            totalDamage = baseDamage * typeMultiplier;
            DefendingPokemon.currentHealthPoints -= (int)totalDamage;
            Console.WriteLine("\n" + AttackingPokemon.species + " used " + AttackingPokemon.moveList[MovesListIndex].name + "!");
            if (typeMultiplier > 1)
            {
                Console.WriteLine("It's super effective!!");
            }
            else if (typeMultiplier == 0)
            {
                Console.WriteLine("It had no effect!");
            }
            else if (typeMultiplier < 1)
            {
                Console.WriteLine("It's not very effective!");
            }
            Console.WriteLine(DefendingPokemon.species + " lost " + (int)totalDamage + " HP!\n\n");
        }

    }
}
