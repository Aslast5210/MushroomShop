using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test121231
{
    public class Mush
    {
        public string Type { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }

        public Mush(string type, double weight)
        {
            Type = type;
            Weight = weight;
            Price = Sale.GetPrice(type, weight);

        }

    }
}
