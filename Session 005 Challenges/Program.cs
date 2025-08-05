using System.Threading.Channels;

namespace Session_005_Challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //(1) Challenge

            Console.WriteLine("Enter number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operation");
            char operation = Convert.ToChar(Console.ReadLine());

            Operation(num1, num2, operation);


            //(2) Challenge

            string Data = "This is a test string.";

            Console.WriteLine(TestData(Data));
        }

        static void Operation(int num1,int num2,char operation)
        {
            switch(operation)
            {
                case '+':
                    Console.WriteLine($"{num1} {operation} {num2} = "+ (num1+num2));
                    break;
                case '-':
                    Console.WriteLine($"{num1} {operation} {num2} = "+ (num1-num2));
                    break;
                case '*':
                    Console.WriteLine($"{num1} {operation} {num2} = " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine($"{num1} {operation} {num2} = " + ((double) num1 / num2));
                    break;
                default:
                    break;
            }
        }

        static int TestData(string Data)
        {
            int Count = 0;

            for(int i=0;i<Data.Length;i++)
            {
                if (Data[i]==' ')
                {
                    Count++;
                }
            }

            return Count;
        }

    }
}
