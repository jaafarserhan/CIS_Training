using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveOilFactory.Library.Machines
{
    public class Hopper
    {


        public string Load(double weight) // OliveBulk as param
        {
            return $"Loaded {weight} kg of olives into the hopper.";
        }

    }
}
