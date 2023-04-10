namespace Math_Game
{
    internal class Program
    {
        private static int DifficultyLevel { get; set; }
        public static int NumberOfQuestions { get; set; }
        public static List<string> Answers = new();
        public static DateTime startTime;

        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");

            var date = DateTime.Now;
            var name = Console.ReadLine();
            while (true)
            {
                Console.Clear();
                ShowMenu(date, name);

                var choice = Console.ReadLine();                

                switch (choice.Trim().ToLower())
                {
                    default:
                        Console.WriteLine("Wrong input!");
                        Environment.Exit(1);
                        break;
                    case "q":
                        Console.WriteLine("Was nice having you here!");
                        Environment.Exit(0);
                        break;
                    case "a":
                        GetComplexityAndAmount();
                        Addition();
                        break;
                    case "s":
                        GetComplexityAndAmount();
                        Substraction();
                        break;
                    case "m":
                        GetComplexityAndAmount();
                        Multiplication();
                        break;
                    case "d":
                        GetComplexityAndAmount();
                        Division();
                        break;
                    case "r":
                        GetComplexityAndAmount();
                        RandomOperators();
                        break;
                    case "l":
                        foreach (var item in Answers)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Press anything to continue");
                        Console.ReadKey();
                        break;

                }

                var endTime = DateTime.Now - startTime;
                Console.WriteLine($"It has taken you {endTime.Minutes} minutes {endTime.Seconds} seconds!");
            }
        }

        private static void GetComplexityAndAmount()
        {
            Console.Write("Choose difficulty level (1-10): ");
            DifficultyLevel = int.Parse(Console.ReadLine().Trim());

            Console.Write("Choose amount of questions: ");
            NumberOfQuestions = int.Parse(Console.ReadLine().Trim());

            Console.WriteLine("Lets go! Time started!");
            startTime = DateTime.Now;
        }

        private static void ShowMenu(DateTime date, string? name)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Hello {name}. It's {date.DayOfWeek} and let's play a math game!");
            Console.WriteLine($@"What game would you like to play? Choose from the options below:
A - Addition
S - Substraction
M - Multiplication
D - Division
R - Random operations
L - List of all answers
Q - Quit
--------------------------------");
        }

        static void Addition() {
            Console.WriteLine("Addtion chosen!");
            Addition(NumberOfQuestions);
        }
        static void Substraction()
        {
            Console.WriteLine("Substraction chosen!");
            Substraction(NumberOfQuestions);
        }
        static void Multiplication()
        {
            Console.WriteLine("Multiplication chosen!");
            Multiplication(NumberOfQuestions);
        }
        static void Division()
        {
            Console.WriteLine("Division chosen!");
            Division(NumberOfQuestions);
        }

        static void Addition(int numberOfTries)
        {
            var random = new Random();
            for (int i = 0; i < numberOfTries; i++) {
                var firstInt = random.Next(1, 5 * DifficultyLevel);
                var secondInt = random.Next(1, 5 * DifficultyLevel);
                Console.Write($"{firstInt} + {secondInt} = ");
                var result = Console.ReadLine();

                bool checkIfCorrect = int.Parse(result.Trim()) == firstInt + secondInt;

                if (checkIfCorrect)
                    Console.WriteLine("This is correct!");
                else
                    Console.WriteLine("This is not correct!");
                Answers.Add($"{firstInt} + {secondInt} = {result}" + (checkIfCorrect ? "" : $" (Correct answer: {firstInt + secondInt})"));
            }
        }
        static void Substraction(int numberOfTries)
        {
            var random = new Random();
            for (int i = 0; i < numberOfTries; i++)
            {
                var firstInt = random.Next(1, 5 * DifficultyLevel);
                var secondInt = random.Next(1, 5 * DifficultyLevel);
                Console.Write($"{firstInt} - {secondInt} = ");
                var result = Console.ReadLine();

                bool checkIfCorrect = int.Parse(result.Trim()) == firstInt - secondInt;

                if (checkIfCorrect)
                    Console.WriteLine("This is correct!");
                else
                    Console.WriteLine("This is not correct!");
                Answers.Add($"{firstInt} - {secondInt} = {result}" + (checkIfCorrect ? "" : $" (Correct answer: {firstInt - secondInt})"));
            }
        }
        static void Multiplication(int numberOfTries)
        {
            var random = new Random();
            for (int i = 0; i < numberOfTries; i++)
            {
                var firstInt = random.Next(1, 5 * DifficultyLevel);
                var secondInt = random.Next(1, 5 * DifficultyLevel);
                Console.Write($"{firstInt} * {secondInt} = ");
                var result = Console.ReadLine();

                bool checkIfCorrect = int.Parse(result.Trim()) == firstInt * secondInt;

                if (checkIfCorrect)
                    Console.WriteLine("This is correct!");
                else
                    Console.WriteLine("This is not correct!");
                Answers.Add($"{firstInt} * {secondInt} = {result}" + (checkIfCorrect ? "" : $" (Correct answer: {firstInt * secondInt})"));
            }
        }
        static void Division(int numberOfTries)
        {
            var random = new Random();
            for (int i = 0; i < numberOfTries; i++)
            {
                var secondInt = random.Next(1, 5 * DifficultyLevel);
                var firstInt = secondInt * random.Next(1, 5 * DifficultyLevel);
                Console.Write($"{firstInt} / {secondInt} = ");
                var result = Console.ReadLine();

                bool checkIfCorrect = int.Parse(result.Trim()) == firstInt / secondInt;

                if (checkIfCorrect)
                    Console.WriteLine("This is correct!");
                else
                    Console.WriteLine("This is not correct!");
                Answers.Add($"{firstInt} / {secondInt} = {result}" + (checkIfCorrect ? "" : $" (Correct answer: {firstInt / secondInt})"));
            }
        }
        static void RandomOperators()
        {
            Console.WriteLine("Random chosen!");
            var random = new Random();

            for (int i = 0; i < NumberOfQuestions; i++)
            {
                var operation = random.Next(4);

                switch (operation)
                {
                    case 0:
                        Addition(1);
                        break;
                    case 1:
                        Substraction(1);
                        break;
                    case 2:
                        Multiplication(1);
                        break;
                    case 3:
                        Division(1);
                        break;
                }
            }
        }
    }
}