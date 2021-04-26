using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency
{
    class PropertyManager
    {
        private List<Property> properties;
        private int propertyID;

        public PropertyManager()
        {
            properties = new List<Property>();
            propertyID = 0;
        }

        public Boolean addProperty(string propertyType, Account s, string addr, int rm, string cond, string lease, double pr, string style)
        {
            if(propertyType == "flat")
            {
                properties.Add(new Flat(s, addr, rm, cond, pr, lease, propertyID));
            }
            if (propertyType == "house")
            {
                properties.Add(new House(s, addr, rm, cond, pr, style, propertyID));
            }

            propertyID++;
            return true;
        }

        public string getPropertyList()
        {
            String str = "";
            foreach(Property property in properties)
            {
                str += property.toString() + "\n";
            }

            return str;
        }

        public Property getProperty(int id)
        {
            foreach(Property property in properties)
            {
                if (property.getID() == id)
                    return property;
            }

            return null;
        }
    }
}
