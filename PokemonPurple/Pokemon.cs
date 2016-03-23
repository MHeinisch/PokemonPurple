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
        public SetUp move = new SetUp();

        public string species;
        string name;
        int level;
        //int attackStat;
        //int defenseStat;
        //int speedStat;
        string typeOne;
        string typeTwo;
        public int typeOneIndex;
        public int typeTwoIndex;

        protected List<Moves> moveList = new List<Moves>();



        //constructor
        public Pokemon()
        {

        }



        //functions
        protected virtual void GenerateMoveList()
        {

        }

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
