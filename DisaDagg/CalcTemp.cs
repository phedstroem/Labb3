namespace DisaDagg;

public class CalcTemp
{
    // Lägger in propertys
    public int Day;
    public int Temp;

    // En konstructor som tar dag och temp
    public CalcTemp(int day, int temp) 
    {
        Day = day;
        Temp = temp;
    }
    // metod för att räkna ut medelvärde.
    // sätter den som "static" för att kunna anropa direkt i klassen utan att göra/instansiera ett objekt va klassen.
    public static int AverageTemp(CalcTemp[] average) // Inparameter tar vi en CalctempArray som vi har i Main.
    {
        int sum = 0;
        // Då elementen i arrayen är av typen CalcTemp och inte "int" så måste jag använda var i loopen.
        foreach (var element in average) 
        {
            sum = sum + element.Temp;
        }
        return sum/average.Length;
    }
    // Vi ska göra en print metod här
    public static void Print(CalcTemp[] array) 
    {        
        // Skriver ut allt. Lägg allt i meny 1, detta kan vi lägga i en klass, en metod "Print" kanske?
        foreach (CalcTemp element in array)
        {
            Console.WriteLine(element.Day + " Maj: " + element.Temp + " °C");
        } 
    }

    // En metod för att leta reda på maxTemperaturen
    public static void MaxTemp(CalcTemp[] array)
    {
        int maxTemp = 0;
        foreach (CalcTemp element in array)
        {
            if (element.Temp > maxTemp)
                maxTemp = element.Temp;
        }
        Console.WriteLine("Maxtemperaturen var: "+ maxTemp);
    }
}