namespace DisaDagg;


class Program
{
    static void Main(string[] args)
    {
        // Skapar en slumpgenerator för temperaturer
        Random random = new Random();

        // Skapar en array av CalcTemp klassen med 31 indexplatser
        CalcTemp[] mayTemps = new CalcTemp[31];


        // Lägger in 31 "CalcTemp"object i arrayen med slumpade temperaturer // VI KAN NOG LÄGGA DEN I KLASSEN...
        // Datumen kommer bli "index +1"
        // En for-loop som kommer snurra igenom alla 31 indexplatser
        for (int i = 0; i < mayTemps.Length; i++)
        {
            // slumpar fram temperatur
            int temperatur = random.Next(1, 34);
            // Lägger in värden för varje objekt. 
            mayTemps[i] = new CalcTemp(i + 1, temperatur);
        }

        // Metod för att skriva ut alla dagar och temperaturer
        CalcTemp.Print(mayTemps);

        // Skriv ut Medeltemåeratur med metoden averageTemp // Lägg i meny 2
        Console.WriteLine("\nHär kommer medeltemperaturen:");
        int averageTemp = CalcTemp.AverageTemp(mayTemps);
        Console.WriteLine(averageTemp + " °C");

        // Test för att skriva ut specifik dag
<<<<<<< HEAD
        
        
=======
>>>>>>> parent of 06f1cc5 (.)
        Console.WriteLine($"Temp: {mayTemps[7].Temp} Dag: {mayTemps[7].Day}");


        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Hej Disa Dagg ");
            Console.WriteLine("Här ska du få lite hjälp med temperaturer för Maj");
            Console.WriteLine("\n1.  Skriv ut samtliga temperaturer");
            Console.WriteLine("2.  Medeltemperaturen");
            Console.WriteLine("3.  Högsta temperaturen"); // och dag
            Console.WriteLine("4.  Lägsta temperaturen "); // och dag
            Console.WriteLine("5.  Mediantemperatur");
            Console.WriteLine("6.  Sortera temperaturerna");
            Console.WriteLine("7.  Filtrera som överstiger XX");
            Console.WriteLine("8.  Väl en dag och visa temp dag före/efter");
            Console.WriteLine("9.  Visa vanligast förekommande temperatur");
            Console.WriteLine("10. Avsluta");
            Console.WriteLine("Vad vill du göra?");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    Console.Write("\nTryck för att fortsätta...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    Console.Write("\nTryck för att fortsätta...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    CalcTemp.MaxTemp(mayTemps);
                    Console.Write("\nTryck för att fortsätta...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "9":
                    break;
                case "10":
                    Console.WriteLine("Du valde att avsluta");
                    isRunning = false;
                    break;
                default:
                    Console.Clear();
                    Console.Write("Ogiltig inmatning, välj alternativ 1-10. Tryck för att fortsätta...");
                    Console.ReadKey();
                    break;
                

            }
        }
    }
}