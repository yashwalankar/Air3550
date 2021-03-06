using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air3550
{
    class flight
    {
        public int Id { get; set; }
        public string origin { get; set; }
        public string dest { get; set; }
        public DateTime deptTime;
        public DateTime arrivalTime;
        public double distance { get; set; }
        public string planeType { get; set; }
        public double cost { get; set; }
        public int maxCapacity { get; set; }
        public int currCapacity { get; set; }

        public void createFlight(string origin, string dest, DateTime deptTime, DateTime arrivalTime, string planeType,
                                    double cost, int maxCapacity, int currCapacity)
        {
            this.origin = origin;
            this.dest = dest;
            this.deptTime = deptTime;
            this.arrivalTime = arrivalTime;
            this.planeType = planeType;
            this.cost = cost;
            this.maxCapacity = maxCapacity;
            this.currCapacity = currCapacity;
            this.maxCapacity = FormDatabaseHelper.getPlaneCapacity(planeType);
            this.distance = FormDatabaseHelper.getDistance(origin, dest);
        }

        
    }
}
