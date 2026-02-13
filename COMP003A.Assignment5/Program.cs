namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Coding Assignment #5!");
        }

        static void UserInfo(string name, int a)
        {
            Console.WriteLine($"\n{name} is a weird name, but {a} is a good number.\n");
        }

        static int CalculateValue(int a)
        {
            return (a * 3);
        }

        static void Main(string[] args)
        {
            int counter = 0;

            WelcomeMessage();

            while (counter < 5) 
            {
                Console.Write("\n\nEnter your name: ");
                string name = Console.ReadLine();

                Console.Write("Enter your favorite number: ");
                int a = int.Parse(Console.ReadLine());

                UserInfo(name, a);

                int b = CalculateValue(a);

                Console.WriteLine($"Calculated value: {b}");

                if (b < 50)
                {
                    Console.WriteLine("The result is less than 50.\n");
                }
                else
                {
                    Console.WriteLine("The result is greater than or equal to 50.\n");
                }

                Console.Write("Would you like to run the program again? (y/n): ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "y":
                        counter++;
                        if (counter >= 5)
                        {
                            Console.WriteLine("\nThat's too many times! I'm done now, goodbye!");
                        }
                        break;

                    case "n":
                        Console.WriteLine("\nThat was fun, goodbye!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\nWhat's that supposed to mean? I'm done now. Goodbye!");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
