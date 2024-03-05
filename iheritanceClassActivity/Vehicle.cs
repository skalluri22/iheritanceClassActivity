using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iheritanceClassActivity
{
    class Vehicle
    {
        // Properties
        public string Brand { get; set; }
        public string Model { get; set; }

        // Behaviors
        public void Start()
        {
            Console.WriteLine("Start the vehicle");
        }

        public void Stop()
        {
            Console.WriteLine("Stop the vehicle...");
        }
    }


}
