using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
	public class Location
	{
        public string Name { get; set; }
        public int ID { get; set; }
        public string Description { get; set; }

        public Event EventHere { get; set; }

        public Location(string description, string name, int id, Event eventHere = null)
        {
            Name = name;
            ID = id;
            Description = description;
            EventHere = eventHere;
        }

	}
}
