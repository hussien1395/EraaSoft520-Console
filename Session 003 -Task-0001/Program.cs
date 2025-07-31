namespace Session_003__Task_0001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 001

            Console.WriteLine("Enter your mark (0-100):");
            int Mark=Convert.ToInt32(Console.ReadLine());
            if (Mark>=90 && Mark<=100)
            {
                Console.WriteLine("Grade: A");
            }
            else if(Mark>=80 && Mark<=89)
            {
                Console.WriteLine("Grade: B");
            }
            else if (Mark >=70 && Mark<=79)
            {
                Console.WriteLine("Grade: C");
            }
            else if(Mark >=60 && Mark <= 69)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }


            // Task 002

            Console.WriteLine("\nEnter a number to print its multiplication table:");
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            while ( i <= 12)
            {
                Console.WriteLine($"{x} * {i} = {x*i}");
                i++;
            }
        }
    }
}
