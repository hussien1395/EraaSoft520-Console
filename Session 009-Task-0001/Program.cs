namespace Session_009_Task_0001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 0;

            try
            {
                Console.WriteLine(x/y);
            }
            catch
            (Exception ex)
            {
                if (ex.ToString().Contains("System.DivideByZeroException"))
                {
                    Console.WriteLine("Sorry you can not Divide By Zero");
                }
            }
            finally
            {
                Console.WriteLine();
            }
        }
    }
}
