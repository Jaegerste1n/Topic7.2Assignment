namespace Topic7._2Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The walls echo your tongue.");
            Console.WriteLine("Message: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            String message = Console.ReadLine();
            for (int i = 1; i <= 10; i = i + 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(i + ". " + message);
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadLine();


        }
    }
}
