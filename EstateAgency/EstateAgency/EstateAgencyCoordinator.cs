using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency
{
    class EstateAgencyCoordinator
    {
        AccountManager accMan;
        OfferManager offMan;
        PropertyManager propMan;
        RecordsManager recMan;
        public EstateAgencyCoordinator()
        {
            accMan = new AccountManager();
            offMan = new OfferManager();
            propMan = new PropertyManager();
            recMan = new RecordsManager();
        }

        public Boolean addBuyer(string name, string address)
        {
            return accMan.addBuyer(name, address);
        }

        public Boolean addSeller(string name, string address)
        {
            return accMan.addSeller(name, address);
        }

        public Account getAccount(int id)
        {
            return accMan.getAccount(id);
        }

        public Boolean addProperty(string propertyType, Account s, string addr, int rm, string cond, string lease, double pr, string style)
        {
            return propMan.addProperty(propertyType, s, addr, rm, cond, lease, pr, style);
        }

        public Property getProperty(int id)
        {
            return propMan.getProperty(id);
        }

        public Boolean makeOffer(Account buyer, Property property, double price)
        {
            return offMan.addOffer(buyer, property, price); 
        }

        public Boolean acceptOffer(int id)
        {
            return recMan.addRecord(offMan.getOffer(id));
        }

        public Offer getOffer(int id)
        {
            return offMan.getOffer(id);
        }
        public void removeOffer(int id)
        {
            offMan.removeOffers(getOffer(id).getProperty().getID());
        }

        public String getAccountsList()
        {
            return accMan.getAccountList();
        }

        public String getOffersList()
        {
            return offMan.getOffersList();
        }

        public String getSellerOffersList(int id)
        {
            return offMan.getSellerOffersList(id);
        }

        public String getPropertiesList()
        {
            return propMan.getPropertyList();
        }

        public String getRecordsList()
        {
            return recMan.getRecordList();
        }

    }
}
