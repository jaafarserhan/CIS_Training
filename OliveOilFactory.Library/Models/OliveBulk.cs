using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveOilFactory.Library.Models
{
    public class OliveBulk
    {
        public int Id { get; set; }
        public double Weight { get; set; } // Weight in kilograms
        public string OwnerName { get; set; }
        public string OliveType { get; set; } // Example: "Koroneiki", "Arbequina"
        public bool IsProcessed { get; set; }
        public string Source { get; set; } // Farm or supplier
        public string Status { get; set; } // Example: "Pending", "Processing", "Completed"
        public List<string> TrackingDetails { get; set; } = new List<string>();
        public double ProducedOilBottles { get; set; } // Bottles produced from this bulk
    }

}
