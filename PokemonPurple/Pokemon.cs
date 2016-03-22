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
        string name;
        int level;
        int experiencePoints = 0;
        //int attackStat;
        //int defenseStat;
        //int speedStat;
        string typeOne;
        string typeTwo;
        int typeOneIndex;
        int typeTwoIndex;

        List<Moves> moveList = new List<Moves>();



        //constructor
        public Pokemon(string Species, int Level, /*int AttackStat, int DefenseStat, int SpeedStat,*/ int TypeOneIndex, int TypeTwoIndex)
        {

        }



        //functions
        void LevelUp()
        {

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
