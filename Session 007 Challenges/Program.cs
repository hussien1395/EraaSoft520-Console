namespace Session_007_Challenges
{

    public class Car
    {
        private double speed;
        private double fuel;

        public Car(double speed, double fuel)
        {
            this.speed = speed;
            this.fuel = fuel;
        }

        public double Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                if (value <= 200) this.speed = value;
            }
        }

        public double Fuel
        {
            get
            {
                return this.fuel;
            }
            set
            {
                if (value >= 0 && value <= 100) this.fuel = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 
            Car car = new Car(180,75);

            car.Speed = 185;
            car.Fuel = 85;

            Console.WriteLine($"Speed : {car.Speed}");
            Console.WriteLine($"Fuel : {car.Fuel}");
        }
    }
}
