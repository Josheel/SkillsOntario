using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency
{
    class OfferManager
    {
        List<Offer> offers;
        int offerNumber;

        public OfferManager()
        {
            offers = new List<Offer>();
            offerNumber = 0;
        }

        public Boolean addOffer(Account buyer, Property property, double price)
        {
            offers.Add(new Offer(buyer, property, price, offerNumber));
            offerNumber++;
            return true;
        }

        public Offer getOffer(int id)
        {
            foreach (Offer offer in offers)
            {
                if (offer.getID() == id)
                    return offer;
            }

            return null;
        }

        public string getOffersList()
        {
            String str = "ID\t Buyer Name\t Property Name\t Offer Amount\n";
            foreach (Offer offer in offers)
            {
                str += offer.toString();
            }

            return str;
        }

        public string getSellerOffersList(int id)
        {
            String str = "ID\t Buyer Name\t Property Name\t Offer Amount\n";
            foreach (Offer offer in offers)
            {
                if(offer.getProperty().getSeller().getID() == id)
                    str += offer.toString();
            }

            return str;
        }

        public void removeOffers(int propertyID)
        {
            foreach(Offer offer in offers)
            {
                if (offer.getProperty().getID() == propertyID)
                    offers.Remove(offer);
            }
        }


    }
}
