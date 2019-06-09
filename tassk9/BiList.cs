using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassk9
{
    class BiList
    {
        public int data;
        public BiList next, last;

        public BiList()
        {
            data = 0;
            next = null;
            last = null;
        }

        public BiList(int d)
        {
            data = d;
            next = null;
            last = null;
        }

        public override string ToString()
        {
            return data.ToString() + " ";
        }
    }
}
