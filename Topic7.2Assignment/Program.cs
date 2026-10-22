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

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The walls echo your tongue.");
            Console.WriteLine("Offering: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            String food = Console.ReadLine();
            for (int i = 1; i <= 10; i = i + 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(i + ". " + food + " Is certainly a choice.");
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The walls echo your tongue.");
            Console.WriteLine("Number: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out int number);
            for (int i = 0; i <= number; i = i + 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(i + ". ");
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The walls echo your tongue.");
            Console.WriteLine("First number: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out int numberOne);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Second number: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out int numberTwo);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Third number: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int.TryParse(Console.ReadLine(), out int numberThree);

            for (int i = numberOne; i <= numberTwo; i = i + numberThree)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(i + ". ");
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Assignment One");

            
            Console.WriteLine("Initiating.");
            for (int i = 10; i >= 1; i = i - 1)
            {
                
                Console.WriteLine(i + ". ");
            }
            Console.WriteLine("Fire!");


            
            Console.WriteLine("Assignment Two");

            
            Console.WriteLine("X \t Y");
            Console.WriteLine("___________");
            for (int i = -10; i <= 10; i = i + 2)
            {
                int y = i * i;
                
                Console.WriteLine(i + "\t" + y);
            }


            
            Console.WriteLine("Assignment Three");

            
            string name;
            Console.WriteLine("Who are you?");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            name = Console.ReadLine().ToLower();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (name == "chungy")
            {
                for (int i = 1; i <= 5; i = i + 1)
                {
                    
                    Console.WriteLine(name);
                }
            }
            else
            {
                for (int i = 1; i <=10; i = i + 1)
                {
                    
                    Console.WriteLine(name);
                }
            }
            
        }
    }
}
