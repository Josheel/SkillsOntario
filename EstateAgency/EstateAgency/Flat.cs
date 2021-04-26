using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgency
{
    class Flat : Property
    {
        private string lease;

        public Flat(Account s, string addr, int rm, string cond, double pr, string ls, int id) : base(s, addr, rm, cond, pr, id)
        {
            lease = ls;
        }
    }
}
