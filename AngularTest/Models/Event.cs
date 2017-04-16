using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularTest.Models
{
    public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Location Location { get; set; }
        public List<Session> Sessions { get; set; }
    }

    public class Location
    {
        public string Address { get; set; }
        public int PostCode { get; set; }
    }

    public class Session
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Level { get; set; }
        public int UpVoteCount { get; set; } 
     }
}