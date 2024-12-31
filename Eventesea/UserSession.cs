using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventesea
{
    public static class UserSession
    {
        public static int UserID { get; set; }
        public static string UserName { get; set; }
        public static string UserEmail { get; set; }
        public static string UserFN { get; set; }
        public static string UserLN { get; set; }
        public static string UserPass { get; set; }

    }

    public static class EventSession
    {
        public static int EventID { get; set; }
        public static string EventName { get; set; }
        public static string EventDate { get; set; }
        public static string EventStart { get; set; }
        public static string EventEnd { get; set; }
        public static string EventTicket { get; set; }

    }
    public static class AttendeeSession
    {
        public static int AttendeeID { get; set; }
        public static string AttendeeName { get; set; }
        public static string AttendeeEmail { get; set; }

    }
    public static class TicketSession
    {
        public static int TicketMax { get; set; }
        public static int TicketSold { get; set; }
        public static int TicketUnsold { get; set; }


    }
}
