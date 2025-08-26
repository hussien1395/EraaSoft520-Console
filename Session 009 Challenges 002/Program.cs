namespace Session_009_Challenges_002
{
    class Player
    {
        public Player(string name, int health, int exp)
        {
            Name = name;
            Health = health;
            Exp = exp;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int Exp { get; set; }

        public static Player operator +(Player player1, Player player2)
        {
            return new Player(player1.Name + "" + player2.Name, player1.Health + player2.Health, player1.Exp + player2.Exp);
        }

        public static Player operator ++(Player player)
        {
            return new Player(player.Name.ToUpper(), player.Health + 1,player.Exp);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Hussien",99,10);
            Player player2 = new Player("Ahmed",80,5);

            Player player3 = player1 + player2;
            Console.WriteLine(player3.Name);
            Console.WriteLine(player3.Health);
            Console.WriteLine(player3.Exp);

            Player player4 =++ player1 ;
            Console.WriteLine(player4.Name);
            Console.WriteLine(player4.Health);
            Console.WriteLine(player4.Exp);
        }
    }
}
