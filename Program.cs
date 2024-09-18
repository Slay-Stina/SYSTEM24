using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Vanliga siffror i deras array och deras summa
            int[] nrArray = { 9, 155, 312 };
            int sum = nrArray.Sum();

            while (true)
            {
                foreach (int i in nrArray)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine(sum);
                Console.WriteLine();
                break;
            }

            static int checkInt()
            {
                while (true)
                {
                    int number;
                    string input = Console.ReadLine();
                    bool correct = int.TryParse(input, out number);

                    if (correct)
                    {
                        return number;
                    }
                    else 
                    Console.WriteLine("Du angav inte en giltig siffra, försök igen!");
                }
            }

            static char checkOp() 
                {
                    while (true)
                    {
                        char ch;
                        string input = Console.ReadLine();
                        bool correct = char.TryParse(input, out ch);

                        if ( ch == '+' || ch == '-' || ch == '*' || ch == '/')
                        {
                            return ch;
                        }
                        else
                            Console.WriteLine("Du angav inte en räknetyp, försök igen!");
                }
                }
            Console.WriteLine("MATTE!");
            Console.Write("Ange en siffra: ");
            int nr1 = checkInt();
            decimal nr1Dec = nr1;
            Console.Write("Ange en till siffra: ");
            int nr2 = checkInt();
            decimal nr2Dec = nr2;

            Console.Write("Ange vad du vill göra med dina siffror: + - * / ");
            char doMath = checkOp();
            switch (doMath)
            {
                case '+':
                    Console.WriteLine(nr1 + nr2);
                    break;
                case '-':
                    Console.WriteLine(nr1 - nr2);
                    break;
                case '*':
                    Console.WriteLine(nr1 * nr2);
                    break;
                case '/':
                    Console.WriteLine(nr1Dec / nr2Dec);
                    break;
                default:
                    break;
            }

            //    Console.Write("Vad heter du? ");
            //    string firstname = Console.ReadLine();
            //    Console.Write("Vart bor du? ");
            //    string city = Console.ReadLine();
            //    Console.Write("Hur gammal är du? ");
            //    string age = Console.ReadLine();

            //    Console.WriteLine("Jag heter " + firstname + " ,jag bor i " + city + " och är " + age + " år gammal!");
            //    Console.WriteLine(string.Format("Jag heter {0}, jag bor i {1} och är {2} år gammal!", firstname, city, age));
            //    Console.WriteLine($"Jag heter {firstname}, jag bor i {city} och är {age} år gammal!");

            //    Console.BackgroundColor = ConsoleColor.DarkGreen;
            //    Console.ForegroundColor = ConsoleColor.Red;

            //    for (int i = 0; i < 11; i++)
            //    {
            //        Console.Write($" {firstname} HAR EN BOMB! ");
            //        Console.Beep();
            //    }
            //    Console.WriteLine();

            //    Console.BackgroundColor = ConsoleColor.Black;
            //    Console.ForegroundColor = ConsoleColor.White;

            //    Console.Write("Ange din favoriträtt: ");
            //    string faveDish = Console.ReadLine();

            //    Console.Write("Ange din vikt i kilo: ");
            //    int weight = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Du väger {weight * 1000} gram!\n");

            //    Console.WriteLine("Idag är det " + DateTime.Now + "\n");

            //    Console.WriteLine("Hur varmt är det i farenheight?");
            //    Console.Write("Ange temperatur i celsius: ");
            //    int celsius = int.Parse(Console.ReadLine());

            double fht = celsius * 1.8 + 32;
            Console.WriteLine($"{celsius} grader i celsius konverteras till {fht} grader i farenheight\n");

            Console.WriteLine("Nu blir det Mad Libs!\n");
            Console.Write("Ange ett substantiv: ");
            string noun = Console.ReadLine();
            Console.Write("Ange ett verb: ");
            string verb = Console.ReadLine();
            Console.Write("Ange ett adjektiv: ");
            string adjective = Console.ReadLine();

            Console.WriteLine($"\nDet var en gång en {noun}! Den skulle ut och plocka blåbär för att sen gå hem och {verb} dem! " +
                $"Det blev som det blev och när den kom hem och gjorde det så blev den {adjective}! SAGAN SLUT!");
        }
    }
}
