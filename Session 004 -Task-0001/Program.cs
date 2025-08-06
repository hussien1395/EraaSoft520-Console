using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace Session_004__Task_0001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of array");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] MyArray = new int[number];

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.WriteLine($"Enter number: {i+1}");
                int num = Convert.ToInt32(Console.ReadLine());
                MyArray[i] = num;
            }

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.Write(MyArray[i] + " ");
               
            }

            int Min=MyArray[0];
            int Max = MyArray[0];
            int Sum = 0;
            int Avg = 0;

            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] < Min) Min = MyArray[i];
                if (MyArray[i] > Max) Max = MyArray[i];
                Sum+= MyArray[i];
            }

            Avg = Sum / MyArray.Length;

            Console.WriteLine($"\nMin : {Min}");
            Console.WriteLine($"Max : {Max}");
            Console.WriteLine($"Avg : {Avg}");
        }
    }
}
