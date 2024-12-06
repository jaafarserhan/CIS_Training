using OliveOilFactory.Library.Machines;
using OliveOilFactory.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveOilFactory.Library.FactoryUnits
{
    public class ProcessingUnit
    {
        public Hopper Hopper { get; set; } = new Hopper();
        public Washer Washer { get; set; } = new Washer();
        public Crusher Crusher { get; set; } = new Crusher();
        public Malaxer Malaxer { get; set; } = new Malaxer();
        public OilDecanter OilDecanter { get; set; } = new OilDecanter();
        public Separator Separator { get; set; } = new Separator();
        public BottlingLine BottlingLine { get; set; } = new BottlingLine();

        public OliveBulk ProcessBulk(OliveBulk bulk)
        {
            if (bulk.IsProcessed)
            {
                Console.WriteLine($"Bulk {bulk.Id} is already processed.");
                return bulk;
            }
            Factory s = new Factory();
            bulk.TrackingDetails.Add(Hopper.Load(bulk.Weight));
            bulk.TrackingDetails.Add(Washer.Wash());
            bulk.TrackingDetails.Add(Crusher.Crush());
            bulk.TrackingDetails.Add(Malaxer.Mix());
            bulk.TrackingDetails.Add(OilDecanter.Decant());
            bulk.TrackingDetails.Add(Separator.Separate());

            bulk.ProducedOilBottles = BottlingLine.Bottle(bulk.Weight);
            bulk.Status = "Completed";
            bulk.IsProcessed = true;
            bulk.TrackingDetails.Add("Process completed.");
            return bulk;
        }

    }
}
