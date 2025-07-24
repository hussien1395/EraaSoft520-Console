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
            double Cost = 0;
            double TaxAmount = 0;
            double TaxPersc = 0;

            Console.WriteLine("Islam's Carpet Cleaning Service Charges:");
            Console.WriteLine("\nPlease enter the price of the small Carpet #");
            SmallCarpetPrice =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPlease enter the price of the large Carpet #");
            LargeCarpetPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nPlease enter the tax %");
            TaxPersc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nThank you for your help in determining the prices.");
            Console.WriteLine($"${SmallCarpetPrice} Per small");
            Console.WriteLine($"${LargeCarpetPrice} Per large");
            Console.WriteLine($"Sales tax rate is {TaxPersc}%");
            Console.WriteLine("Estimates are valid for 30 days");
            Console.WriteLine("\nPlease enter number of small Carpet #");
            NumberofSmallCarpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease enter number of large Carpet #");
            NumberofLargeCarpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEstimate for carpet cleaning service");
            Console.WriteLine($"Number of small carpets: {NumberofSmallCarpet} <--");
            Console.WriteLine($"Number of large carpets: {NumberofLargeCarpet} <--");
            Console.WriteLine($"Price per small room: ${SmallCarpetPrice}");
            Console.WriteLine($"Price per large room: ${LargeCarpetPrice}");

             Cost = Convert.ToDouble((NumberofSmallCarpet * SmallCarpetPrice) + (NumberofLargeCarpet * LargeCarpetPrice));
            TaxAmount = Convert.ToDouble((Cost * TaxPersc)/100);
            Console.WriteLine($"Cost: ${Cost}");
            Console.WriteLine($"Tax: ${TaxAmount}");
            Console.WriteLine("========================================");
            Console.WriteLine($"Total estimate: {Cost + TaxAmount}");
            Console.WriteLine("This estimate is valid for 30 days");
            Console.WriteLine($"\n+ - * /");


        }
    }
}
