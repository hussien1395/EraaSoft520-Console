namespace EraaSoft_Task_0001
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double SmallCarpetPrice = 0;
            double LargeCarpetPrice = 0;
            int NumberofSmallCarpet = 0;
            int NumberofLargeCarpet = 0;

            Console.WriteLine("Islam's Carpet Cleaning Service Charges:");
            Console.WriteLine("\nPlease enter the price of the small Carpet #");
            SmallCarpetPrice =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPlease enter the price of the large Carpet #");
            LargeCarpetPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nThank you for your help in determining the prices.");
            Console.WriteLine($"${SmallCarpetPrice} Per small");
            Console.WriteLine($"${LargeCarpetPrice} Per large");
            Console.WriteLine("Sales tax rate is 6%");
            Console.WriteLine("Estimates are valid for 30 days");
            Console.WriteLine("\nPlease enter number of small Carpet #");
            NumberofSmallCarpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease enter number of large Carpet #");
            NumberofLargeCarpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEstimate for carpet cleaning service");
            Console.WriteLine($"Number of small carpets: {NumberofSmallCarpet} <--");
            Console.WriteLine($"Number of large carpets: {NumberofLargeCarpet} <--");

        }
    }
}
