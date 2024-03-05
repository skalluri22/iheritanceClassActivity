namespace iheritanceClassActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of Car
            Car myCar = new Car();
            myCar.Brand = "BMW";
            myCar.Model = "i20";
            myCar.Year = 2023;
            myCar.Color = "blue";

            // Using behaviors of Car class
            myCar.Start();
            myCar.Accelerate();
            // Using behaviors of Vehicle class
            myCar.Stop();
            myCar.Brake();

            Console.WriteLine($"My {myCar.Year} {myCar.Brand} {myCar.Model} is {myCar.Color}.");
        }
    }
}
