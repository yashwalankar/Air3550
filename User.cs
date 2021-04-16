using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air3550
{
    public class User
    {
        public int id { get; set; }
        public int type { get; set; }
        public int age { get; set; }
        public int rewardBalance { get; set; }
        public int userHistoryID { get; set; }
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
