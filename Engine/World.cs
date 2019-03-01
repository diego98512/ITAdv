using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Engine
{
	public class World
	{
        public static readonly List<Location> Locations = new List<Location>();
        public static readonly List<Event> Events = new List<Event>();


        public const int LOCATION_ID_IT_DEPARTMENT = 1;



        public const int EVENT_ID_INTRODUCTION = 1;



        static World()
        {
            PopulateLocations();
            PopulateEvents();
        }

        private static void PopulateEvents()
        {
            throw new NotImplementedException();
        }

        private static void PopulateLocations()
        {
            throw new NotImplementedException();
        }
    }
}
