using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform_Demo02
{
    public class Pair
    {
        private string v;
        private int s;
        public Pair(string v, int s)
        {
            this.v = v;
            this.s = s;
        }
        public string V
        {
            get { return v; }
            set { this.v = value; }
        }
        public int S
        {
            get { return s; }
            set { this.s = value; }
        }
    }
}
