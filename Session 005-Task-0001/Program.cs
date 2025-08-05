namespace Session_005_Task_0001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> MyList = new List<int>();
            CheckOptions(ref MyList);
        }

        static void CheckOptions(ref List<int> list)
        {
            string option;

            do
            {
                PrintMenu();
                option = SelectOption().ToUpper();

                switch (option)
                {
                    case "P":
                        Print(ref list);
                        break;
                    case "A":
                        Add(ref list);
                        break;
                    case "M":
                        Avg(ref list);
                        break;
                    case "S":
                        Smallest(ref list);
                        break;
                    case "L":
                        Largest(ref list);
                        break;
                    case "F":
                        Found(ref list);
                        break;
                    case "C":
                        Clear(ref list);
                        break;
                    case "Q":
                        break;
                    default:
                        Console.WriteLine("Unknown selection, please try again");
                        Console.WriteLine("<<<---------------------------------------->>>");
                        break;
                }
            } while (option != "Q");
        }

        static void PrintMenu()
        {
            Console.WriteLine("\nPlease select option from a menu to perform operations on the list");
            Console.WriteLine("\nP - Print numbers");
            Console.WriteLine("A - Add a number");
            Console.WriteLine("M - Display mean of the numbers");
            Console.WriteLine("S - Display the smallest number");
            Console.WriteLine("L - Display the largest number");
            Console.WriteLine("F - Search for a number in the list and if found display the index");
            Console.WriteLine("C - Clearing out the list (make it empty again)");
            Console.WriteLine("Q - Quit");
            Console.WriteLine("\nEnter your choice:");
        }

        static string SelectOption()
        {
            return Console.ReadLine();
        }

        static void Print(ref List<int> MyList)
        {
            Console.Write("[");
            for (int i = 0; i < MyList.Count; i++)

            {
                Console.Write(" " + MyList[i]);
            }
            Console.Write(" ]");

            Console.WriteLine("\n<<<---------------------------------------->>>");
        }

        static void Add(ref List<int> MyList)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            MyList.Add(num);
            Console.WriteLine($"{num} Added Successfully");
            Console.WriteLine("<<<---------------------------------------->>>");
        }

        static void Avg(ref List<int> MyList)
        {
            if (MyList.Count > 0)
            {
                int Sum = 0;
                int Avg = 0;

                for (int i = 0; i < MyList.Count; i++)
                {
                    Sum += MyList[i];
                }

                Avg = Sum / MyList.Count;
                Console.WriteLine($"Average: {Avg}");
            }
            else
            {
                Console.WriteLine("Unable to calculate the average  - no data");
            }

            Console.WriteLine("<<<---------------------------------------->>>");
        }

        static void Smallest(ref List<int> MyList)
        {
            if (MyList.Count > 0)
            {
                int Smallest = MyList[0];

                for (int i = 0; i < MyList.Count; i++)
                {
                    if (Smallest < MyList[i])
                    {
                        Smallest = Smallest;
                    }
                    else
                    {
                        Smallest = MyList[i];
                    }
                }

                Console.WriteLine($"Smallest: {Smallest}");
            }
            else
            {
                Console.WriteLine("Unable to determine the smallest number - list is empty");
            }

            Console.WriteLine("<<<---------------------------------------->>>");
        }

        static void Largest(ref List<int> MyList)
        {
            if (MyList.Count > 0)
            {
                int Largest = MyList[0];

                for (int i = 0; i < MyList.Count; i++)
                {
                    if (Largest > MyList[i])
                    {
                        Largest = Largest;
                    }
                    else
                    {
                        Largest = MyList[i];
                    }
                }

                Console.WriteLine($"Largest: {Largest}");
            }
            else
            {
                Console.WriteLine("Unable to determine the largest number - list is empty");
            }

            Console.WriteLine("<<<---------------------------------------->>>");
        }

        static void Found(ref List<int> MyList)
        {
            if (MyList.Count > 0)
            {
                int index = -1;
                Console.WriteLine("Enter number");
                int num = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < MyList.Count; i++)
                {
                    if (num == MyList[i]) index = i;
                }

                if (index != -1) Console.WriteLine($"Index of {num}: {index}");
                else Console.WriteLine("Not found");

            }
            else Console.WriteLine("Unable to search - list is empty");

            Console.WriteLine("<<<---------------------------------------->>>");
        }

        static void Clear(ref List<int> MyList)
        {
            if (MyList.Count > 0)
            {
                MyList.Clear();
                Console.WriteLine("Clear Successfully");
            }
            else Console.WriteLine("List is empty");

            Console.WriteLine("<<<---------------------------------------->>>");
        }
    }
}
