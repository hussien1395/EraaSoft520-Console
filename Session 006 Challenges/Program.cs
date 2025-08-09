namespace Session_006_Challenges
{
    public class Mobile
    {

        public string Model { get; set; }
        public string Realse { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }

        public Mobile(string model, string realse, double price, string color)
        {
            Model = model;
            Realse = realse;
            Price = price;
            Color = color;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Mobile mobile1 = new Mobile("Iphone", "13", 30000, "Balck");
                Mobile mobile2 = new Mobile("Samaunge", "12", 30000, "Wite");

                Console.WriteLine("<<<<< Mobile 1 >>>>>");
                Console.WriteLine($"Model: {mobile1.Model}");
                Console.WriteLine($"Realse: {mobile1.Realse}");
                Console.WriteLine($"Price: {mobile1.Price}");
                Console.WriteLine($"Color: {mobile1.Color}");

                Console.WriteLine("\n<<<<< Mobile 2 >>>>>");
                Console.WriteLine($"Model: {mobile2.Model}");
                Console.WriteLine($"Realse: {mobile2.Realse}");
                Console.WriteLine($"Price: {mobile2.Price}");
                Console.WriteLine($"Color: {mobile2.Color}");
            }
        }
    }
}
