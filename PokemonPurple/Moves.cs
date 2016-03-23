using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Moves
    {

        //member variables
        string name;
        int power;
        int accuracy;
        int powerPoints;
        int moveTypeIndex;



        //constructor
        public Moves(string Name, int Power, int Accuracy, int PowerPoints, int MoveTypeIndex)
        {
            name = Name;
            power = Power;
            accuracy = Accuracy;
            powerPoints = PowerPoints;
            moveTypeIndex = MoveTypeIndex;
        }

        public Moves()
        {

        }



        //functions
        void CalculateCriticalHit()
        {

        }

        void CalculateMovePowerWithRandom()
        {

        }

        void CalculateMoveAccuracy()
        {

        }

    }
}
