using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClumps
{
    public static class EventHelper
    {
        public static void RegisterEvent(EventDetails eventDetails)
        {
            Console.WriteLine($"Event: {eventDetails.EventName}, Date: {eventDetails.EventDate}, Location: {eventDetails.Location}");
        }
    }
}
