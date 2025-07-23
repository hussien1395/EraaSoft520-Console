namespace EraaSoft520_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // (1) Challenge
            Console.WriteLine("EraaSoft520");

            // (2) Challenge
            Console.WriteLine("Write your fav number from 1 to 100");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wow you number " + number + " is my fav also");
            Console.WriteLine($"Wow you number {number} is my fav also");
            Console.WriteLine("Wow you number {0} is my fav also", number);
        }
    }
}
