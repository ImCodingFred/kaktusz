using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaktusz
{
    internal class kaktusz
    {
        public string knev { get; set; }
        public string tnev { get; set; }
        public string tnehez { get; set; }
        public int vigeny { get; set; }
        public int figeny { get; set; }

        public kaktusz(string be) 
        {
            string[] dbok = be.Split(';');
            knev = dbok[0];
            tnev = dbok[1];
            tnehez = dbok[2];
            vigeny = int.Parse(dbok[3]);
            figeny = int.Parse(dbok[4]);
        }
    }
}
