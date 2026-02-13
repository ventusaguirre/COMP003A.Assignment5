namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Coding Assignment #5!\n");
        }


        static void UserInfo(string name, int a)
        {
            Console.WriteLine($"\nYour name is {name} and your favorite number is {a}.\n");
        }

        static int CalculateValue(int a)
        {
            return (a * 3);
        }

        static void Main(string[] args)
        {

            WelcomeMessage();

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your favorite number: ");
            string number = Console.ReadLine();
            int a = int.Parse(number);

            UserInfo(name, a);

            Console.WriteLine($"Calculated value: {CalculateValue(a)}");



        }
    }
}
