

namespace iheritanceClassActivity
{
    class Car : Vehicle
    {
        // Properties
        public int Year { get; set; }
        public string Color { get; set; }

        // Behaviors
        public void Accelerate()
        {
            Console.WriteLine("Accelerating the car...");
        }

        public void Brake()
        {
            Console.WriteLine("Applying brakes...");
        }
    }
}
