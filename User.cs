using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Air3550
{
    public class User
    {
        int id;
        int type;
        int age;
        int rewardBalance;
        int userHistoryID;
        string passwordhash;
        string name;
        string address;
        string cardNumber;

        List<string> bookedFlights;
        List<string> takenFlights;
        List<string> canceledFlights;

        public User()
        {

        }

        // Information Setters
        public void setID(int UserID) { id = UserID; }
        
        public void setType(int userType) { type = userType; }

        public void setAge(int userAge) { age = userAge; }

        public void setRewardBalance(int userRewPoints) { rewardBalance = userRewPoints; }
    
        public void setUserHistoryID(int userHistID) { userHistoryID = userHistID; }

        public void setPassHash(string encryptedPassword) { passwordhash = encryptedPassword; }

        public void setName(string userName) { name = userName; }

        public void setAddress(string userAdd) { address = userAdd; }

        public void setCardNumber(string cardNum) { cardNumber = cardNum; }

        // Information Getters
        public int getID() { return id; }

        public int getType() { return type; }

        public int getAge() { return age; }

        public int getRewardBalance() { return rewardBalance; }

        public int getUserHistoryID() { return userHistoryID; }

        public string getPassHash() { return passwordhash; }

        public string getName() { return name; }

        public string getAddress() { return address; }

        public string getCardNumber() { return cardNumber; }

        // Information Methods
    }

}
