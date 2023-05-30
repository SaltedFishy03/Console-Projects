namespace Lige_og_ulige_tal
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool isNumeric;
            ConsoleKeyInfo esc;

            do
            {
                Console.Clear();

                Console.Write("skriv et tal: ");
                //double tal = Convert.ToDouble(Console.ReadLine());

                isNumeric = double.TryParse(Console.ReadLine(), out double tal);

                if (!isNumeric)
                {
                    Console.WriteLine("Indsæt kun tal!");
                    Console.WriteLine("tryk på enter for at prøve igen");
                    Console.WriteLine("\n (tryk på esc for at afslutte programmet)");
                    continue;
                }

                double restTal = tal % 2;

                if (restTal == 0)
                {
                    Console.WriteLine("dette tal er lige");
                }

                else
                {
                    Console.WriteLine("tal er ulige");
                }

                Console.WriteLine("tryk på esc for at afslutte programmet");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);



            do
            {
                Console.Clear();

                Console.Write("skriv et tal: ");
                //double tal = Convert.ToDouble(Console.ReadLine());

                isNumeric = double.TryParse(Console.ReadLine(), out double tal);

                if (!isNumeric)
                {
                    Console.WriteLine("Indsæt kun tal!");
                    Console.WriteLine("tryk på enter for at prøve igen");
                    Console.WriteLine("\n (tryk på esc for at afslutte programmet)");
                    continue;
                }

                double restTal = tal % 2;

                if (restTal == 0)
                {
                    Console.WriteLine("dette tal er lige");
                }

                else
                {
                    Console.WriteLine("tal er ulige");
                }

                Console.WriteLine("tryk på esc for at afslutte programmet");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}