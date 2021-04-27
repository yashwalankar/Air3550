using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air3550
{
    public class UserFlightHistory
    {
        public int userID;
        public int type;
        public int status;
        public String originAbv;
        public String connectionAbv;

        public String finaldestAbv;


        public int leg1bookingId;
        public DateTime leg1deptDate;
        public DateTime leg1ArrivalDate;


        public int leg2bookingId;
        public DateTime leg2deptDate;
        public DateTime leg2ArrivalDate;

        public DateTime departureDate;
        public DateTime arrivalDate;

        public int paymentType;
        public double paymentAmount;

        public UserFlightHistory(int userID, int leg1Id, int leg2Id)
        {
            this.userID = userID;
            
            this.leg1bookingId = leg1Id;
            this.leg2bookingId = leg2Id;
 
            flight leg1_flight = FormDatabaseHelper.getFlight_fromBookingTable(leg1Id);
            originAbv = leg1_flight.origin;
            leg1deptDate = leg1_flight.deptTime;
            leg1ArrivalDate = leg1_flight.arrivalTime;

            departureDate = leg1deptDate;
            this.paymentAmount = leg1_flight.cost;
            flight leg2_flight;
            if (leg2Id == 0)
            {
                finaldestAbv = leg1_flight.dest;
                connectionAbv = null;
                arrivalDate = leg1ArrivalDate;
            }
            else
            {
                leg2_flight = FormDatabaseHelper.getFlight_fromBookingTable(leg2Id);
                finaldestAbv = leg2_flight.dest;
                connectionAbv = leg2_flight.origin;
                leg2deptDate = leg2_flight.deptTime;
                leg2ArrivalDate = leg2_flight.arrivalTime;

                arrivalDate = leg2ArrivalDate;
                this.paymentAmount = this.paymentAmount + leg2_flight.cost +8;
            }



        }

    }
}
/*[UserHistId]      INT NOT NULL,

[userdID]         INT           NOT NULL,

[Type]            INT           NOT NULL,

[Status]          INT           NOT NULL,

[OriginAbv]       NVARCHAR (50) NOT NULL,

[Leg1BookedID]    INT           NOT NULL,

[Leg1ArrivalTime] DATETIME      NOT NULL,

[Leg2BookedID]    INT           NULL,

[Leg2Departure]   DATETIME      NULL,

[connectionAbv]   NVARCHAR (50) NULL,
    [finaldestAbv]    NVARCHAR (50) NOT NULL,
    [DepartureDate]   DATETIME      NOT NULL,
    [ArrivalDate]     DATETIME      NOT NULL,
    [PaymentType]     INT           NOT NULL,
    [PaymentAmount]   FLOAT     NOT NULL,*/