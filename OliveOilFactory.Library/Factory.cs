using OliveOilFactory.Library.FactoryUnits;
using OliveOilFactory.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveOilFactory.Library
{
    public class Factory
    {
        public List<OliveBulk> OliveBulks { get; set; } = new List<OliveBulk>();
        public ProcessingUnit ProcessingUnit { get; set; } = new ProcessingUnit();

        public void AddOliveBulk(OliveBulk bulk) //bulk 1 is added 
        {
            OliveBulks.Add(bulk);
            Console.WriteLine($"Added olive bulk {bulk.Id} from {bulk.OwnerName}.");
        }
                public void StartProcessing()
        {
            foreach (var bulk in OliveBulks)
            {
                if (!bulk.IsProcessed)
                {
                    Console.WriteLine($"Processing bulk {bulk.Id}...");
                    ProcessingUnit.ProcessBulk(bulk);
                }
            }
        }

        public void DisplayReport()
        {
            Console.WriteLine("Factory Report:");
            foreach (var bulk in OliveBulks)
            {
                Console.WriteLine($"Bulk {bulk.Id}:");
                Console.WriteLine($"  Owner: {bulk.OwnerName}");
                Console.WriteLine($"  Weight: {bulk.Weight} kg");
                Console.WriteLine($"  Status: {bulk.Status}");
                Console.WriteLine($"  Produced Bottles: {bulk.ProducedOilBottles}");
                Console.WriteLine($"  Tracking Details:");
                foreach (var detail in bulk.TrackingDetails)
                {
                    Console.WriteLine($"    - {detail}");
                }
            }
        }

    }
}
