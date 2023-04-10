namespace Math_Game
{
    internal class Program
    {
        private static int DifficultyLevel { get; set; }
        public static int NumberOfQuestions { get; set; }

        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");

            var date = DateTime.Now;
            var name = Console.ReadLine();
            ShowMenu(date, name);

            var choice = Console.ReadLine();

            Console.Write("Choose difficulty level (1-10): ");
            DifficultyLevel = int.Parse(Console.ReadLine().Trim());

            Console.Write("Choose amount of questions: ");
            NumberOfQuestions = int.Parse(Console.ReadLine().Trim());

            switch (choice.Trim().ToLower())
            {
                case "a":
                    Addition();
                    break;
                case "s":
                    Substraction();
                    break;
                case "m":
                    Multiplication();
                    break;
                case "d":
                    Division();
                    break;
                case "q":
                    Console.WriteLine("Was nice having you here!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Wrong input!");
                    Environment.Exit(1);
                    break;
            }
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
Q - Quit
--------------------------------");
        }

        static void Addition()
        {
            Console.WriteLine("Addtion chosen!");
            var random = new Random();
            for (int i = 0; i < NumberOfQuestions; i++) {
                var firstInt = random.Next(1, 5 * DifficultyLevel);
                var secondInt = random.Next(1, 5 * DifficultyLevel);
                Console.Write($"{firstInt} + {secondInt} = ");
                var result = Console.ReadLine();

                if (int.Parse(result.Trim()) == firstInt + secondInt)
                    Console.WriteLine("This is correct!");
                else
                    Console.WriteLine("This is not correct!");
            }
        }
        static void Substraction()
        {
            Console.WriteLine("Substraction chosen!");
            var random = new Random();
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                var firstInt = random.Next(1, 5 * DifficultyLevel);
                var secondInt = random.Next(1, 5 * DifficultyLevel);
                Console.Write($"{firstInt} - {secondInt} = ");
                var result = Console.ReadLine();

                if (int.Parse(result.Trim()) == firstInt - secondInt)
                    Console.WriteLine("This is correct!");
                else
                    Console.WriteLine("This is not correct!");
            }
        }
        static void Multiplication()
        {
            Console.WriteLine("Multiplication chosen!");
            var random = new Random();
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                var firstInt = random.Next(1, 5 * DifficultyLevel);
                var secondInt = random.Next(1, 5 * DifficultyLevel);
                Console.Write($"{firstInt} * {secondInt} = ");
                var result = Console.ReadLine();

                if (int.Parse(result.Trim()) == firstInt * secondInt)
                    Console.WriteLine("This is correct!");
                else
                    Console.WriteLine("This is not correct!");
            }
        }
        static void Division()
        {
            Console.WriteLine("Division chosen!");
            var random = new Random();
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                var secondInt = random.Next(1, 5 * DifficultyLevel);
                var firstInt = secondInt * random.Next(1, 5 * DifficultyLevel);
                Console.Write($"{firstInt} / {secondInt} = ");
                var result = Console.ReadLine();

                if (int.Parse(result.Trim()) == firstInt / secondInt)
                    Console.WriteLine("This is correct!");
                else
                    Console.WriteLine("This is not correct!");
            }
        }
    }
}