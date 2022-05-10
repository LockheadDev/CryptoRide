using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBlockChainApp
{
    //ENUMS
    public enum LabelType { neutral, warning,critical, good}

    //CLASSES
    internal class Ride
    {

        //Publisher data
        public int avatarNum;
        public string ethereumAddress;

        //Ride info
        public int id;
        public string location;
        public DateTime date;
        public DateTime fromTime, toTime;
        public int avSeats;
        public double cost;

        public Ride(int id,int avatarNum, string ethereumAddress, string location, int avSeats, DateTime date, DateTime fromTime,DateTime toTime,double cost)
        {
            this.id = id;
            this.avatarNum = avatarNum;
            this.ethereumAddress = ethereumAddress;
            this.location = location;
            this.avSeats = avSeats;
            this.date = date;
            this.fromTime = date + fromTime.TimeOfDay;
            this.toTime = date + toTime.TimeOfDay;
            this.cost = cost;
            
        }
    }
    internal class User
    {
        public int avatarNum;
        public string name;
        public string ethereumAddress;
        public List<Ride> myrides= new List<Ride>();
        public Ride activeOfferRide;

        public User()
        {
            this.name = null;
            this.avatarNum = -1;
            this.ethereumAddress = null;
        }

        public User(int avatarNum,string name, string ethereumAddress)
        {
            this.name = name;
            this.avatarNum = avatarNum;
            this.ethereumAddress = ethereumAddress;
        }
    }
}
