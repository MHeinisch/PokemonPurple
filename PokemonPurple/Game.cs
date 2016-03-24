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
        Zones zone = new Zones();
        UI ui2 = new UI();
        

        List<Zones> zoneList = new List<Zones>();


        public Zones pokecenter = new Poke_Center();
        public Zones abandonedfactory = new Abandoned_Factory();
        public Zones alternatedimension = new Alternate_Dimension();
        public Zones mountain = new Mountain();
        public Zones rainforest = new Rainforest();
        public Zones route1 = new Route_1();
        public Zones indigoplateau = new Indigo_Plateau();



        //constructor
        public Game()
        {

        }



        //functions
        public void FillZoneList()
        {
            zoneList.Add(pokecenter);
            zoneList.Add(route1);
            zoneList.Add(mountain);
            zoneList.Add(rainforest);
            zoneList.Add(abandonedfactory);
            zoneList.Add(alternatedimension);
            zoneList.Add(indigoplateau);
        }

        public void SelectZone()
        {
            Console.WriteLine("Please select a Zone to enter:");
            int zoneChoiceInt = ui2.GetUserInputZoneSelection(zoneList);
        }

    }
}
