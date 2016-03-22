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



        //functions
        void GenerateMovesList()
        {
            Moves tackle = new Moves("Tackle", 50, 100, 35, 1);
            Moves bodyslam = new Moves("Body Slam", 85, 100, 15, 1);            //can paralyze
            Moves megakick = new Moves("Mega Kick", 120, 75, 5, 1);
            Moves ember = new Moves("Ember", 40, 100, 25, 2);                   //can burn
            Moves flamethrower = new Moves("Flamethrower", 90, 100, 15, 2);     //can burn
            Moves fireblast = new Moves("Fire Blast", 110, 85, 5, 2);           //can burn
            Moves watergun = new Moves("Water Gun", 40, 100, 25, 3);
            Moves surf = new Moves("Surf", 90, 100, 15, 3);
            Moves hydropump = new Moves("Hydro Pump", 110, 80, 5, 3);
            Moves thundershock = new Moves("Thunder Shock", 40, 100, 30, 4);    //can paralyze
            Moves thunderbolt = new Moves("Thunderbolt", 90, 100, 15, 4);       //can paralyze
            Moves thunder = new Moves("Thunder", 110, 70, 10, 4);               //can paralyze
            Moves vinewhip = new Moves("Vine Whip", 45, 100, 25, 5);
            Moves leafblade = new Moves("Leaf Blade", 90, 100, 15, 5);          //high crit chance
            Moves seedflare = new Moves("Seed Flare", 120, 85, 5, 5);           //can lower target SDef
            Moves powdersnow = new Moves("Powder Snow", 40, 100, 25, 6);        //can freeze
            Moves icebeam = new Moves("Ice Beam", 90, 100, 10, 6);              //can freeze
            Moves blizzard = new Moves("Blizzard", 110, 70, 5, 6);              //can freeze
            Moves karatechop = new Moves("Karate Chop", 50, 100, 25, 7);        //high crit chance
            Moves aurasphere = new Moves("Aura Sphere", 80, 100, 20, 7);        //never misses
            Moves focusblast = new Moves("Focus Blast", 120, 70, 5, 7);         //can lower target SDef
            Moves acid = new Moves("Acid", 40, 100, 30, 8);                     //can lower target SDef
            Moves poisonjab = new Moves("Poison Jab", 80, 100, 20, 8);          //can poison
            Moves gunkshot = new Moves("Gunk Shot", 120, 80, 5, 8);             //can poison
            Moves mudshot = new Moves("Mud Shot", 55, 95, 15, 9);               //lower target Speed
            Moves earthpower = new Moves("Earth Power", 90, 100, 10, 9);        //can lower target SDef
            Moves earthquake = new Moves("Earthquake", 100, 100, 10, 9);
            Moves gust = new Moves("Gust", 40, 100, 35, 10);            
            Moves drillpeck = new Moves("Drill Peck", 80, 100, 20, 10);
            Moves hurricane = new Moves("Hurricane", 110, 70, 10, 10);          //can confuse
            Moves confusion = new Moves("Confusion", 50, 100, 25, 11);          //can confuse
            Moves psychic = new Moves("Psychic", 90, 100, 10, 11);              //can lower target SDef
            Moves psychoboost = new Moves("Psycho Boost", 140, 90, 5, 11);      //lower user SAtk
            Moves strugglebug = new Moves("Struggle Bug", 50, 100, 20, 12);     //lower target SAtk
            Moves xscissor = new Moves("X-Scissor", 80, 100, 15, 12);
            Moves megahorn = new Moves("Megahorn", 120, 85, 10, 12);
            Moves rockthrow = new Moves("Rock Throw", 50, 90, 15, 13);
            Moves powergem = new Moves("Power Gem", 80, 100, 20, 13);
            Moves stoneedge = new Moves("Stone Edge", 100, 80, 5, 13);          //high crit chance
            Moves shadowsneak = new Moves("Shadow Sneak", 40, 100, 30, 14);     //always goes first
            Moves shadowpunch = new Moves("Shadow Punch", 60, 100, 20, 14);     //never misses
            Moves shadowball = new Moves("Shadow Ball", 80, 100, 15, 14);       //can lower target SDef
            Moves twister = new Moves("Twister", 40, 100, 20, 15);              //can flinch
            Moves dragonpulse = new Moves("Dragon Pulse", 85, 100, 10, 15);
            Moves dragometeor = new Moves("Draco Meteor", 130, 90, 5, 15);      //lower user SAtk
            Moves pursuit = new Moves("Pursuit", 40, 100, 20, 16);              //double damage if target switches
            Moves nightslash = new Moves("Night Slash", 70, 100, 15, 16);       //high crit chance
            Moves foulplay = new Moves("Foul Play", 95, 100, 15, 16);           //damage calculated from target Atk instead of Def
            Moves bulletpunch = new Moves("Bullet Punch", 40, 100, 30, 17);     //always goes first
            Moves flashcannon = new Moves("Flash Cannon", 80, 100, 10, 17);     //can lower target SDef
            Moves irontail = new Moves("Iron Tail", 100, 75, 15, 17);           //can lower target Def
            Moves fairywind = new Moves("Fairy Wind", 40, 100, 30, 18);
            Moves dazzlinggleam = new Moves("Dazzling Gleam", 80, 100, 10, 18);
            Moves moonblast = new Moves("Moonblast", 95, 100, 15, 18);          //can lower target SAtk
        }

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
