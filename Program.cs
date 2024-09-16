namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nr1 = 123;
            int nr2 = 321;
            Console.WriteLine(nr1 + nr2);

            Console.Write("Vad heter du? ");
            string firstname = Console.ReadLine();
            Console.Write("Vart bor du? ");
            string city = Console.ReadLine();
            Console.Write("Hur gammal är du? ");
            string age = Console.ReadLine();

            Console.WriteLine("Jag heter " + firstname + " ,jag bor i " + city + " och är " + age + " år gammal!");
            Console.WriteLine(string.Format("Jag heter {0}, jag bor i {1} och är {2} år gammal!", firstname, city, age));
            Console.WriteLine($"Jag heter {firstname}, jag bor i {city} och är {age} år gammal!");

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Red;

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
            Console.WriteLine($"Du väger {weight * 1000} gram!\n");

            Console.WriteLine("Idag är det " + DateTime.Now + "\n");

            Console.WriteLine("Hur varmt är det i farenheight?");
            Console.Write("Ange temperatur i celsius: ");
            int celsius = int.Parse(Console.ReadLine());

            double fht = celsius * 1.8 + 32;
            Console.WriteLine($"{celsius} grader i celsius konverteras till {fht} grader i farenheight");

        }
    }
}
