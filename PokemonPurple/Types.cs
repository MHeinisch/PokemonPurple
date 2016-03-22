using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPurple
{
    class Types
    {

        //member variables
        int attackTypeIndex;

        public string[] typeArray = new string[19];
        public double[,] typeMatchup2DArray = new double[19, 19]; //[row, column] row = attack type, column = target types



        //constructor
        public Types()
        {

        }



        //functions
        void CalculateTypeMultiplier()
        {

        }

        void CalculateSTAB()
        {

        }

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

        void FillTypeEffectivenessTwoDArray()
        {
            FillTypeEffectivenessTwoDArrayWithOnes();
            FillTypeEffectivenessTwoDArrayWithMultipliers();
        }
            void FillTypeEffectivenessTwoDArrayWithOnes()
            {
                for(int indexOuterArray = 0; indexOuterArray <= 18; indexOuterArray++)
                {
                    for(int indexInnerArray = 0; indexInnerArray <= 18; indexInnerArray++)
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

    }
}