namespace ConCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo esc;

            do
            {
                Console.Clear();

                Console.WriteLine("Velkommen til ConCalc");
                Console.WriteLine("---------------------");

                Console.WriteLine("---------------------");
                Console.WriteLine("1. Plus");
                Console.WriteLine("2. Træk fra");
                Console.WriteLine("3. Gange");
                Console.WriteLine("4. Dividere");
                Console.WriteLine("5. udregn nettoløn");
                Console.WriteLine("6. årlige kørselsfradrag");
                Console.WriteLine("---------------------");
                Console.Write("Vælg funktion: ");                                               //her skal jeg vægle en funktion oven over som jeg vil regne med 

                string menuvalg = Console.ReadLine();                                           //i denne sektion læser den og tjekker den mit valgte svar i de andre "strings"


                //den her "double" command beskytter min lommeregner-

                switch (menuvalg)
                {
                    case "1":
                        simplecal("+");
                        break;

                    case "2":
                        simplecal("-");
                        break;

                    case "3":
                        simplecal("*");
                        break;

                    case "4":
                        simplecal("/");
                        break;

                    case "5":
                        double bruttoløn = ReadDouble("bruttoløn: ");
                        double månedsFradrag = ReadDouble("månedsfradrag: ");
                        double trækProcent = ReadDouble("trækprocent: ");
                        print(bruttoløn - ((bruttoløn - månedsFradrag) / 100) * trækProcent);
                        break;

                    case "6":
                        double årligAbejdsdage = ReadDouble("antal arbejdsdage om året: ");
                        double antalKilometer = ReadDouble("antal kilometer til arbejde: ");

                        print(årligAbejdsdage * (antalKilometer * 2));
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("vælg en metode");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("tryk esc for at lukke lommeregner\n");
                        break;
                }

                esc = Console.ReadKey();

            } while (esc.Key != ConsoleKey.Escape);                                        //her har jeg lavet et loop ved hjælp af jeg gemmer en key på mit keyboard ved at skrive "consolekeyinfo" og så navngiver den.
                                                                                           //ved hjælp af while command, hvor jeg siger hvis alt andet en esc bliver trykked på køre den programmet oven over


            static void simplecal(string sign)
            {
                if (sign == "+")
                {
                    double tal1 = ReadDouble("Tal 1: ");
                    double tal2 = ReadDouble("Tal 2: ");
                    print(tal1 + tal2);

                    return;
                }

                if (sign == "-")
                {
                    double tal1 = ReadDouble("Tal 1: ");
                    double tal2 = ReadDouble("Tal 2: ");
                    print(tal1 - tal2);

                    return;
                }

                if (sign == "*")
                {
                    double tal1 = ReadDouble("Tal 1: ");
                    double tal2 = ReadDouble("Tal 2: ");
                    print(tal1 * tal2);

                    return;
                }

                if (sign == "/")
                {

                    double tal1 = ReadDouble("Tal 1: ");
                    double tal2 = ReadDouble("Tal 2: ");
                    print(tal1 / tal2);

                    return;
                }
            }

            static double ReadDouble(string prompt)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();


                bool isNumeric = false;                                                     //dette er et check for at se om jeg har det rette input så mit program ikke crasher

                do
                {
                    if (input == "")
                    {
                        Console.WriteLine("Ingen tomme strenge!");
                        input = Console.ReadLine();
                        continue;
                    }

                    isNumeric = double.TryParse(input, out double n);

                    if (!isNumeric)
                    {
                        Console.WriteLine("Indsæt kun tal!");
                        input = Console.ReadLine();
                    }

                } while (!isNumeric);

                input = input.Replace(".", ",");
                double value = Convert.ToDouble(input);
                return value;

            }

            static void print(double resultat)
            {
                Console.WriteLine("-------------------- -");
                Console.Write("Resultat: ");
                Console.WriteLine(resultat);
                Console.WriteLine("---------------------");

                Console.WriteLine("tryk esc for at lukke lommeregner\n");

            }

        }
    }
}