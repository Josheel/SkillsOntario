using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency
{
    class Property
    {
        private string address;
        private string condition;
        private int rooms;
        private double price;
        private int propertyID;
        private Account seller;

        public Property(Account s, string addr, int rm, string cond, double pr, int id)
        {
            address = addr;
            rooms = rm;
            condition = cond;
            price = pr;
            propertyID = id;
            seller = s;
        }

        public int getID() { return propertyID; }
        public Account getSeller() { return seller; }
        public string getAddress() { return address; }
        public string toString()
        {
            return propertyID + " " + address;
        }

    }
}
