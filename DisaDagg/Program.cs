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


        // Skriver ut allt. Lägg allt i meny 1, detta kan vi lägga i en klass, en metod "Print" kanske?
        foreach (CalcTemp element in mayTemps)
        {
            Console.WriteLine(element.Day + " Maj: " + element.Temp + " °C");
        }


        // Skriv ut Medeltemåeratur med metoden averageTemp // Lägg i meny 2
        Console.WriteLine("\nHär kommer medeltemperaturen:");
        int averageTemp = CalcTemp.AverageTemp(mayTemps);
        Console.WriteLine(averageTemp + " °C");

        Console.WriteLine($"Temp: {mayTemps[7].Temp} Dag: {mayTemps[7].Day}");



    }
}