using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveOilFactory.Library.Machines
{
    public class BottlingLine
    {
        public double Bottle(double weight)
        {
            double oilYield = weight * 0.2; // Assume 20% yield from olives
            double bottleVolume = 20; // 20L bottles
            int bottles = (int)(oilYield / bottleVolume);
            return bottles;
        }

    }
}
