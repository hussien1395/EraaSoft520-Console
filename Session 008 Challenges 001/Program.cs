namespace Session_008_Challenges_001
{

    public class Animal
    {
        public string name { get; set; }
        public int age { get; set; }

        public  virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
        
    }

    public class Pig : Animal
    {
        public int size { get; set; }

        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    public class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow bow");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myPig = new Pig();
            Animal myDog = new Dog();

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();
        }
    }
}
