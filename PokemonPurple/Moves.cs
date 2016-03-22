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
