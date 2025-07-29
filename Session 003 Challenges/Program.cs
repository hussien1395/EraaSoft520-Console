namespace Session_003_Challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // (1) Challenge
            Console.WriteLine("Please enter your score:");
            int Score = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Are you Attend?");
            char Attend = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(Attend != 'Y' || Score < 50);

            // (2) Challenge
            Console.WriteLine("Please Enter Your Number:");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (x < 0)
            {
                Console.WriteLine("Negative"); 
            }
            else
            {
                Console.WriteLine("Zero");
            }

            // (3) Challenge
            Console.WriteLine("Please Enter Your Number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
