using System;
using System.Collections.Generic;

namespace EventApi.Contracts.Models.Meetup
{
    public class GetMeetupResponse
    {
        public int MeetupAmount { get; set; }
        public List<MeetupView> Meetups { get; set; }
    }

    public class MeetupView
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Organizer { get; set; }
        public DateTime EventDate { get; set; }
        public int House { get; set; }
        public int Building { get; set; }
        public string Street { get; set; }

        //public List<Sponsor> Sponsors { get; set; }
    }
}
