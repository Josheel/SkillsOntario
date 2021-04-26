using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency
{
    class Record
    {
        Offer offer;
        double finalPrice;

        public Record(Offer off)
        {
            offer = off;
            finalPrice = calculateFinalPrice();
        }

        private double calculateFinalPrice()
        {
            return offer.getAmount() * 1.13;
        }

        public string toString()
        {
            return offer.getBuyer().toString() + "\t " + offer.getProperty().getSeller().getName() + "\t " + offer.getProperty().getAddress() + 
                "\t " + offer.getAmount() + "\t " + finalPrice;
        }
        
    }
}
