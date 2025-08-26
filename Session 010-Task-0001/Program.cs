namespace Session_010_Task_0001
{
    internal class Program
    {

        private static List<Question> questionBank = new List<Question>();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Examination System");
                Console.WriteLine("1. Doctor Mode");
                Console.WriteLine("2. Student Mode");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DoctorMode();
                        break;
                    case "2":
                        StudentMode();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        public static void DoctorMode()
        {
            Console.Clear();
            Console.Write("Enter number of questions to add: ");
            int numQuestions = int.Parse(Console.ReadLine());

            for (int i = 0; i < numQuestions; i++)
            {
                Console.WriteLine($"Enter details for Question {i + 1}:");

                Console.Write("Enter question type (1. True/False, 2. Choose One, 3. Multiple Choice): ");
                int type = int.Parse(Console.ReadLine());

                Console.Write("Enter question level (1. Easy, 2. Medium, 3. Hard): ");
                int level = int.Parse(Console.ReadLine());
                QuestionLevel questionLevel = (QuestionLevel)(level - 1);

                Console.Write("Enter question header: ");
                string header = Console.ReadLine();

                Console.Write("Enter marks: ");
                int marks = int.Parse(Console.ReadLine());

                Question question = null;

                switch (type)
                {
                    case 1:
                        Console.Write("Enter correct answer (True/False): ");
                        bool correctAnswer = Console.ReadLine().ToLower() == "true";
                        question = new TrueFalseQuestion(header, marks, questionLevel, correctAnswer);
                        break;
                    case 2:
                        string[] choices = new string[4];
                        for (int j = 0; j < 4; j++)
                        {
                            Console.Write($"Enter choice {j + 1}: ");
                            choices[j] = Console.ReadLine();
                        }
                        Console.Write("Enter correct choice number (1-4): ");
                        int correctChoice = int.Parse(Console.ReadLine());
                        question = new ChooseOneQuestion(header, marks, questionLevel, choices, correctChoice);
                        break;
                    case 3:
                        string[] multiChoices = new string[4];
                        bool[] correctChoices = new bool[4];
                        for (int j = 0; j < 4; j++)
                        {
                            Console.Write($"Enter choice {j + 1}: ");
                            multiChoices[j] = Console.ReadLine();
                        }
                        Console.Write("Enter correct choices (comma separated): ");
                        string[] correctAnswers = Console.ReadLine().Split(',');
                        for (int j = 0; j < 4; j++)
                        {
                            correctChoices[j] = correctAnswers.Contains((j + 1).ToString());
                        }
                        question = new MultipleChoiceQuestion(header, marks, questionLevel, multiChoices, correctChoices);
                        break;
                    default:
                        Console.WriteLine("Invalid question type.");
                        return;
                }

                questionBank.Add(question);
            }

            Console.WriteLine("Questions added successfully!");
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }

        public static void StudentMode()
        {
            Console.Clear();
            Console.Write("Enter exam type (1. Practical, 2. Final): ");
            int examType = int.Parse(Console.ReadLine());
            Console.Write("Enter level (1. Easy, 2. Medium, 3. Hard): ");
            int level = int.Parse(Console.ReadLine());
            QuestionLevel questionLevel = (QuestionLevel)(level - 1);

            List<Question> examQuestions = questionBank.Where(q => q.Level == questionLevel).ToList();

            if (examType == 1)
            {
                examQuestions = examQuestions.Take(examQuestions.Count / 2).ToList();
            }

            int score = 0;
            foreach (var question in examQuestions)
            {
                question.Display();
                string userAnswer = Console.ReadLine();
                if (question.CheckAnswer(userAnswer))
                {
                    score += question.Marks;
                }
            }

            Console.WriteLine($"Your Result: {score} / {examQuestions.Sum(q => q.Marks)}");
            Console.WriteLine("Press any key to return to main menu.");
            Console.ReadKey();
        }

    public enum QuestionLevel
        {
            Easy,
            Medium,
            Hard
        }

        public abstract class Question
        {
            public string Header { get; set; }
            public int Marks { get; set; }
            public QuestionLevel Level { get; set; }

            public Question(string header, int marks, QuestionLevel level)
            {
                Header = header;
                Marks = marks;
                Level = level;
            }

            public abstract void Display();
            public abstract bool CheckAnswer(string userAnswer);
        }

        public class TrueFalseQuestion : Question
        {
            public bool CorrectAnswer { get; set; }

            public TrueFalseQuestion(string header, int marks, QuestionLevel level, bool correctAnswer)
                : base(header, marks, level)
            {
                CorrectAnswer = correctAnswer;
            }

            public override void Display()
            {
                Console.WriteLine($"{Header} (True/False):");
            }

            public override bool CheckAnswer(string userAnswer)
            {
                return (userAnswer.ToLower() == (CorrectAnswer ? "true" : "false"));
            }
        }

        public class ChooseOneQuestion : Question
        {
            public string[] Choices { get; set; }
            public int CorrectChoice { get; set; }

            public ChooseOneQuestion(string header, int marks, QuestionLevel level, string[] choices, int correctChoice)
                : base(header, marks, level)
            {
                Choices = choices;
                CorrectChoice = correctChoice;
            }

            public override void Display()
            {
                Console.WriteLine($"{Header} (Choose One):");
                for (int i = 0; i < Choices.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {Choices[i]}");
                }
            }

            public override bool CheckAnswer(string userAnswer)
            {
                return int.TryParse(userAnswer, out int choice) && choice == CorrectChoice;
            }
        }

        public class MultipleChoiceQuestion : Question
        {
            public string[] Choices { get; set; }
            public bool[] CorrectChoices { get; set; }

            public MultipleChoiceQuestion(string header, int marks, QuestionLevel level, string[] choices, bool[] correctChoices)
                : base(header, marks, level)
            {
                Choices = choices;
                CorrectChoices = correctChoices;
            }

            public override void Display()
            {
                Console.WriteLine($"{Header} (Multiple Choice):");
                for (int i = 0; i < Choices.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {Choices[i]}");
                }
            }

            public override bool CheckAnswer(string userAnswer)
            {
                var userChoices = userAnswer.Split(',');
                foreach (var choice in userChoices)
                {
                    if (int.TryParse(choice, out int parsedChoice))
                    {
                        if (!CorrectChoices[parsedChoice - 1])
                            return false;
                    }
                }
                return true;
            }
        }


    }
}
