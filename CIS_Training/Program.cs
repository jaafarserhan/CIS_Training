using OliveOilFactory.Library;
using OliveOilFactory.Library.Models;

namespace CIS_Training
{
    public class Program
    {


        public static void Main(string[] args)
        {

            Factory factory = new Factory();

            OliveBulk bulk1 = new OliveBulk
            {
                Id = 1,
                Weight = 500, // 500kg
                OwnerName = "John Doe",
                OliveType = "Koroneiki",
                Source = "Local Farm",
                Status = "Pending"
            };

            factory.AddOliveBulk(bulk1);
            factory.StartProcessing();
            factory.DisplayReport();
        }
    }
}