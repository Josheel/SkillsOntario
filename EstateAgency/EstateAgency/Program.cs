using System;

namespace EstateAgency
{
    class Program
    {
        public static void addBuyer(EstateAgencyCoordinator eac)
        {
            String name, address;

            Console.Clear();
            name = getString("Enter buyer name:");
            address = getString("Enter buyer address: ");

            if (eac.addBuyer(name, address))
                Console.WriteLine("Buyer added...");
            else
                Console.WriteLine("Could not add buyer...");

            returnToMain();
        }

        public static void addSeller(EstateAgencyCoordinator eac)
        {
            String name, address;

            Console.Clear();
            Console.WriteLine("-------- Add Seller --------");
            name = getString("Enter seller name:");
            address = getString("Enter seller address: ");

            if (eac.addSeller(name, address))
                Console.WriteLine("Seller added...");
            else
                Console.WriteLine("Could not add seller...");

            returnToMain();
        }

        public static void addProperty(EstateAgencyCoordinator eac)
        {
            string propertyType, address, condition, leaseRemaining, style;
            int rooms, sellerID;
            double price;
            Account seller;

            Console.Clear();
            Console.WriteLine("------- Add Property --------");
            propertyType = getString("Enter property type(Flat or House): ").ToLower();
            address = getString("Enter address: ");
            condition = getString("Enter condition: ");
            rooms = getInteger("Enter number of rooms: ");
            Console.Write("Enter listing price: ");
            price = Convert.ToDouble(Console.ReadLine());
            sellerID = getInteger("Enter seller ID: ");

            leaseRemaining = style = "";

            seller = eac.getAccount(sellerID);
            if(seller == null)
            {
                Console.WriteLine("Seller does not exists...");
                returnToMain();
                return;
            }
            else if(seller.getAccountType() != "seller")
            {
                Console.WriteLine("This account is not a seller...");
                returnToMain();
                return;
            }

            if (propertyType == "flat")
            {
                leaseRemaining += getString("Enter remaining lease: ");
                eac.addProperty(propertyType, seller, address, rooms, condition, leaseRemaining, price, style);
                Console.WriteLine("Flat was added");
            }
            else if (propertyType == "house")
            {
                style += getString("Enter the style of the house: ");
                eac.addProperty(propertyType, seller, address, rooms, condition, leaseRemaining, price, style);
                Console.WriteLine("House was added");
            }
            else
                Console.WriteLine("Invalid property type...");

            returnToMain();

        }

        public static void getAccountsList(EstateAgencyCoordinator eac)
        {
            Console.Clear();
            Console.WriteLine("-------- List of Accounts --------");
            Console.WriteLine(eac.getAccountsList());
            returnToMain();
        }

        public static void getPropertiesList(EstateAgencyCoordinator eac)
        {
            Console.Clear();
            Console.WriteLine("-------- List of Properties --------");
            Console.WriteLine(eac.getPropertiesList());
            returnToMain();
        }

        public static void makeOffer(EstateAgencyCoordinator eac)
        {
            Account buyer;
            Property property;
            double amount;

            Console.Clear();
            Console.WriteLine("-------- Make Offer --------");
            buyer = eac.getAccount(getInteger("Enter the buyer ID: "));
            if(buyer == null)
            {
                Console.WriteLine("Buyer does not exist");
                returnToMain();
                return;
            }

            property = eac.getProperty(getInteger("Enter property ID: "));
            if (property == null)
            {
                Console.WriteLine("Property does not exist");
                returnToMain();
                return;
            }

            amount = getInteger("Enter offer: ");

            if (eac.makeOffer(buyer, property, amount))
                Console.WriteLine("Offer was made");
            else
                Console.WriteLine("Could not make offer");

            returnToMain();
        }

        public static void getOffersList(EstateAgencyCoordinator eac)
        {
            Console.Clear();
            Console.WriteLine("-------- List of Offers --------");
            Console.WriteLine(eac.getOffersList());
            returnToMain();
        }

        public static void acceptOffer(EstateAgencyCoordinator eac)
        {
            int sellerID, offerID;
            Console.Clear();
            Console.WriteLine("-------- Accept Offer --------");
            sellerID = getInteger("Enter sellers ID: ");
            Console.WriteLine(eac.getSellerOffersList(sellerID));
            offerID = getInteger("Enter ID of offer to accept: ");
            if (eac.acceptOffer(offerID))
            {
                Console.WriteLine("Offer accepted");
                eac.removeOffer(offerID);
            }
            else
                Console.WriteLine("Offer was not accepter");

            returnToMain();
        }

        public static void getRecordsList(EstateAgencyCoordinator eac)
        {
            Console.WriteLine(eac.getRecordsList());
        }

        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Humber Estate Agency");
            Console.WriteLine("Please choose an option from the following menu:");
            Console.WriteLine("1.  Add Buyer Account\n2.  Add Seller Account\n3.  Add Property\n4.  Get Account List");
            Console.WriteLine("5.  Get Properties List\n6.  Make an Offer\n7.  Get List of Offers\n8.  Accept Offer");
            Console.Write("9.  Get Records\n10. Exit\nOption:");
        }

        public static string getString(string str)
        {            
            Console.Write(str);
            return Console.ReadLine();
        }

        public static int getInteger(string str)
        {
            Console.Write(str);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void returnToMain()
        {
            Console.WriteLine("Press any key to return to previous menu");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            EstateAgencyCoordinator eac = new EstateAgencyCoordinator();
            int option;

            do
            {
                menu();
                option = getInteger("");
                switch (option)
                {
                    case 1:
                        addBuyer(eac);
                        break;
                    case 2:
                        addSeller(eac);
                        break;
                    case 3:
                        addProperty(eac);
                        break;
                    case 4:
                        getAccountsList(eac);
                        break;
                    case 5:
                        getPropertiesList(eac);
                        break;
                    case 6:
                        makeOffer(eac);
                        break;
                    case 7:
                        getOffersList(eac);
                        break;
                    case 8:
                        acceptOffer(eac);
                        break;
                    case 9:
                        getRecordsList(eac);
                        break;
                    case 10:
                        Console.WriteLine("You are now exiting, goodbye...");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option");
                        break;
                }

            } while (option!= 10);

        }
    }
}
