using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency
{
    class Offer
    {
        Account buyer;
        Property property;
        double amount;
        int offerID;

        public Offer(Account b, Property p, double a, int id)
        {
            buyer = b;
            property = p;
            amount = a;
            offerID = id;
        }

        public int getID() { return offerID; }

        public Property getProperty() { return property; }
        public Account getBuyer() { return buyer; }
        public double getAmount() { return amount; }


        public string toString()
        {
            return offerID + "\t " + buyer.toString() + "\t " + property.toString() + "\t " + amount + "\n";
        }

    }
}
