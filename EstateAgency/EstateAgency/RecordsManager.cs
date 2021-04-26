using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency
{
    class RecordsManager
    {
        List<Record> records;

        public RecordsManager()
        {
            records = new List<Record>();
        }

        public Boolean addRecord(Offer offer)
        {
                records.Add(new Record(offer));
                return true;
        }

        public string getRecordList()
        {
            string str = "Buyer Name\t Seller Name\t Property Address\t Accepted Offer\t Final Price\n";
            foreach(Record record in records)
            {
                str += record.toString();
            }

            return str;
        }
    }
}
