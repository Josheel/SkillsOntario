using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency
{
    class House : Property
    {
        private string style;
        public House(Account s, string addr, int rm, string cond, double pr, string st, int id) : base(s, addr, rm, cond, pr, id)
        {
            style = st;
        }
    }
}
