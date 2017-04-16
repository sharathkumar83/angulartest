using AngularTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularTest.Controllers
{
    public class EventsController : ApiController
    {
        /*
        // GET: api/events/5
        public string Get(int id)
        {
            return "value";
        }
        */

        // GET: api/events/5
        public Event Get(string id = null)
        {
            var sessions = this.GetSessions();
            return new Event
            {
                Name = "Angular Test",
                Date = DateTime.Today,
                Location = new Location()
                {
                    Address = "Sydney",
                    PostCode = 2151
                },
                Sessions = sessions
            };
        }

        public void Post(string id, string eventData)
        {
            var path = System.Web.Hosting.HostingEnvironment.MapPath("/");
            System.IO.File.WriteAllText(path + id + ".json", eventData);
        }

        #region Session Data
        private List<Session> GetSessions()
        {
            var sessionsList = new List<Session>();
            sessionsList.Add(new Models.Session()
            {
                Name = "Session A",
                Level = "Beginer",
                Duration = 1,
                UpVoteCount = 0
            });

            sessionsList.Add(new Models.Session()
            {
                Name = "Session B",
                Level = "Inter",
                Duration = 30,
                UpVoteCount = 0
            });

            sessionsList.Add(new Models.Session()
            {
                Name = "Session C",
                Level = "Expert",
                Duration = 1,
                UpVoteCount = 0
            });

            sessionsList.Add(new Models.Session()
            {
                Name = "Session D",
                Level = "Beginer",
                Duration = 1,
                UpVoteCount = 0
            });

            sessionsList.Add(new Models.Session()
            {
                Name = "Session E",
                Level = "Inter",
                Duration = 1,
                UpVoteCount = 0
            });

            sessionsList.Add(new Models.Session()
            {
                Name = "Session F",
                Level = "Expert",
                Duration = 1,
                UpVoteCount = 0
            });
            sessionsList.Add(new Models.Session()
            {
                Name = "Session G",
                Level = "Beginer",
                Duration = 1,
                UpVoteCount = 0
            });

            return sessionsList;
        }
        #endregion
    }
}
