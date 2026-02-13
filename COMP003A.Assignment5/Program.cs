namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Coding Assignment #5!");
        }


        static void UserInfo(string name, int number)
        {
            Console.WriteLine("Enter your name: ");
        }

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int number = Console.ReadLine();

            WelcomeMessage();
            UserInfo();

        }
    }
}
