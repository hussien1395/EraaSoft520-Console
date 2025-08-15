namespace Session_008_Challenges_002
{

    class Generic<T>
    {
        public static void PrintTwice(T x)
        {
            Console.WriteLine($"{x} {x}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            double y = 5.5;
            string name = "Hussien";
            Generic<int>.PrintTwice(x);
            Generic<string>.PrintTwice(name);
            Generic<double>.PrintTwice(y);

        }
    }
}
