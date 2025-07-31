namespace Session_004_Challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(1) Challenge

            Console.WriteLine("Please enter your number");
            int num = Convert.ToInt32(Console.ReadLine());
            int Total = 0;

            for (int i = 1; i <= num; i++)
            {
                Total += i;
            }

            Console.WriteLine($"Sum of numbers: {Total}");

            //(2) Challenge

            Console.WriteLine("Please enter count of numbers");
            int Count = Convert.ToInt32(Console.ReadLine());

            int Odd = 0;
            int Even = 0;

            for (int i = 1; i <= Count; i++)
            {
                Console.WriteLine($"Please enter your number {i} #");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x % 2 == 0)
                {
                    Even += 1;
                }
                else
                {
                    Odd += 1;
                }
            }

            Console.WriteLine($"Even # {Even}");
            Console.WriteLine($"Odd # {Odd}");


            //(3) Challenge

            int SumValidNumber = 0;
            Console.WriteLine("<<<< Please enter 10 numbers >>>>");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Please enter your number {i} # ");
                int x = Convert.ToInt32(Console.ReadLine());

                if (x < 0)
                {
                    Console.WriteLine("Negative numbers are skipped");
                    continue;
                }
                else if (x == 999)
                {
                    Console.WriteLine("Stop Signal received");
                    break;
                }
                else
                {
                    Console.WriteLine("non-negative and not 999");
                    SumValidNumber += x;
                }

            }

            Console.WriteLine($"Sum of valid numbers {SumValidNumber}");




        }
    }
}
