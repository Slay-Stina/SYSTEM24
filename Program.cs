namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int nr1 = 123;
            int nr2 = 321;
            Console.WriteLine(nr1 + nr2);

            string firstname = Console.ReadLine();
            string city = Console.ReadLine();
            string age = Console.ReadLine();

            Console.WriteLine("Jag heter " + firstname + " ,jag bor i " + city + " och är " + age + " år gammal!");
            Console.WriteLine(string.Format("Jag heter {0}, jag bor i {1} och är {2} år gammal!", firstname, city, age));
            Console.WriteLine($"Jag heter {firstname}, jag bor i {city} och är {age} år gammal!");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            for (int i = 0; i < 11; i++)
            {
                Console.Write($" {firstname} HAR EN BOMB! ");
                Console.Beep();
            }
            Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Ange din favoriträtt: ");
            string faveDish = Console.ReadLine();

            Console.Write("Ange din vikt i kilo: ");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine($"Du väger {weight * 1000} gram!");

            Console.WriteLine("Idag är det " + DateTime.Now);
        }
    }
}
