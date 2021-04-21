using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air3550
{
    class flight
    {
        String origin;
        String dest;
        String deptTime,arrivalTime;
        double distance;
        String planeType;
        int maxCapacity;
        int currCapacity;

        flight(String origin,String dest, String deptTime,String arrivalTime,String planeType,int currCapacity)
        {
            this.origin = origin;
            this.dest = dest;
            this.deptTime = deptTime;
            this.arrivalTime = arrivalTime;
            this.planeType = planeType;
            this.currCapacity = currCapacity;
            this.maxCapacity = FormDatabaseHelper.getPlaneCapacity(planeType);
            this.distance = FormDatabaseHelper.getDistance(origin, dest);
        }

        
    }
}
