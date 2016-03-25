using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Pokemon
    {

        //member variables        
        public string species;
        //string nickname;
        public int level;
        //int attackStat;
        //int defenseStat;
        //int speedStat;
        public int typeOneIndex;
        public int typeTwoIndex;
        public int maxHealthPoints;
        public int currentHealthPoints;

        bool isActive;

        public List<Moves> moveList = new List<Moves>();



        //constructor
        public Pokemon()
        {

        }



        //functions


        public void GeneratePlayerStarterPokemon(int UserInput, Trainer Player)
        {
            Pokemon Starter;// = new Pokemon();
            while (UserInput == 1 || UserInput == 2 || UserInput == 3)
            {
                if (UserInput == 1)
                {
                    Starter = new Bulbasaur();
                    UserInput = 0;
                }
                else if (UserInput == 2)
                {
                    Starter = new Charmander();
                    UserInput = 0;
                }
                else
                {
                    Starter = new Squirtle();
                    UserInput = 0;
                }
                Starter.level = 5;
                Starter.maxHealthPoints = Starter.level * 5;
                Starter.currentHealthPoints = Starter.maxHealthPoints;
                Player.partyList.Add(Starter);
            }
            //return Starter;
        }

        public void GenerateRivalStarterPokemon(List<Pokemon> PlayerPartyList, Pokemon Starter, Trainer Rival)
        {
            if (PlayerPartyList[0].species.Equals("Bulbasaur"))
            {
                Starter = new Charmander();
            }
            else if (PlayerPartyList[0].species.Equals("Charmander"))
            {
                Starter = new Squirtle();
            }
            else
            {
                Starter = new Bulbasaur();
            }
            Starter.level = 5;
            Starter.maxHealthPoints = Starter.level * 5;
            Starter.currentHealthPoints = Starter.maxHealthPoints;
            Rival.partyList.Add(Starter);
        }

        public void LevelUp(Pokemon UserPokemon)
        {
            level += 1;
            Console.WriteLine(UserPokemon.species + " leveled up!");
            Console.WriteLine(UserPokemon.species + " is level " + UserPokemon.level + "!");
        }

        void GainExperiencePoints()
        {

        }

        void IncreaseStats()
        {

        }
        
        void IncreaseAttackStat()
        {

        }

        void IncreaseDefenseStat()
        {

        }

        void IncreaseSpeedStat()
        {

        }

        void LearnNewMove()
        {

        }

    }
}
