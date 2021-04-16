using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air3550
{
    public class User
    {
        public string id { get; set; }
        public string type { get; set; }
        public string age { get; set; }
        public string rewardBalance { get; set; }
        public string userHistoryID { get; set; }
        public string passwordHash { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string cardNumber { get; set; }

        List<string> bookedFlights;
        List<string> takenFlights;
        List<string> canceledFlights;

        public User()
        {

        }

        // Information Methods


    }

}
