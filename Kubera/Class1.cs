using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kubera
{
    public class Rupiah {
        private long data;
        public Rupiah(long d)
        {
            data = d;
        }

        public long Data { get => data; }
        public override string ToString()
        {
            return "";
        }
    }
}
