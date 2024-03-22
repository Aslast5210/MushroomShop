using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test121231
{
    public class Sale
    {
        public static double GetPrice(string type, double weight)
        {
            // ราคาต่อกิโลกรัม
            double pricePerKg = 100;

            // ตรวจสอบประเภทเห็ด
            switch (type)
            {
                case "เห็ดนางฟ้า":
                    pricePerKg = 80;
                    break;
                case "เห็ดเข็มทอง":
                    pricePerKg = 90;
                    break;
                case "เห็ดออรินจิ":
                    pricePerKg = 120;
                    break;
            }

            return pricePerKg * weight;
        }
    }
}
