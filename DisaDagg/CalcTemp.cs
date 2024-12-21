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

    // Vi gör en print metod här
    public static void Print(CalcTemp[] array) 
    {        
        // Skriver ut allt. Lägg allt i meny 1, detta kan vi lägga i en klass, en metod "Print" kanske?
        foreach (CalcTemp element in array)
        {
            Console.WriteLine(element.Day + " Maj: " + element.Temp + " °C");
        } 
    }

    // Vi gör en till print metod här för sorterade arrayen
    public static void PrintSort(CalcTemp[] array)
    {
        // Skriver ut allt.
        foreach (CalcTemp element in array)
        {
            Console.WriteLine(element.Temp + " °C  - " + element.Day + " Maj");
        }
    }

    // En metod för att leta reda på maxTemperaturen
    public static void MaxTemp(CalcTemp[] array)
    {
        int maxTemp = 0;
        int day = 0;
        foreach (CalcTemp element in array)
        {
            // OM "element.Temp" är större än "maxTemp" så går vi in i if satsen.
            // Vi tilldelar då "maxTemp" = "element.Temp" och "day" = "element.Day"
            // För att få ut både temp och dag
            // https://csharpskolan.se/article/algoritmer-en-introduktion/
            if (element.Temp > maxTemp)
            {
                maxTemp = element.Temp;
                day = element.Day;
            }
        }
        Console.WriteLine("Maxtemperaturen var " + maxTemp + " °C den " + day + " Maj");

    }
    // En metod för att leta reda på MinTemperaturen
    public static void MinTemp(CalcTemp[] array)
    {
        int minTemp = 35;
        int day = 0;
        foreach (CalcTemp element in array)
        {
            if (element.Temp < minTemp)
            {
                minTemp = element.Temp;
                day = element.Day;
            }

        }
        Console.WriteLine("Lägsta temperaturen var " + minTemp + " °C den " + day + " Maj");
    }
    // Metod för sortering Bubblesort
    // https://csharpskolan.se/article/algoritmer-en-introduktion/
    // Vi skickar tillbaka en "CalcTemp" array nu, därav "CalcTemp[]" istället för void.
    public static CalcTemp[] SortArray(CalcTemp[] array)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i].Temp > array[i + 1].Temp)
                {
                    // Vi skiftar temperaturerna
                    CalcTemp swap = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = swap;

                }
            }

        }
        // Skickar tillbaka en sorterad array
        return array;
    }
    // Metod för att filtrera och skriva ut temperaturer.
    public static void FilterTemps(CalcTemp[] array, int thresholdValue)
    {
        List<CalcTemp> filterdList = new List<CalcTemp>();

        for (int i = 0; i < array.Length; i++)
        {
            if (thresholdValue < array[i].Temp)
            {
                filterdList.Add(array[i]);
            }

        }
        if (filterdList.Count > 0)
        {
            Console.Clear();
            Console.WriteLine("Dessa dagar har en temperatur över " + thresholdValue + " °C");
            Console.WriteLine();
            for (int i = 0; i < filterdList.Count; i++)
            {
                Console.WriteLine(filterdList[i].Day + " Maj  - " + filterdList[i].Temp + " °C");
            }
            Console.WriteLine("\nTryck för att fortsätta");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Det finns ingen temperatur som överstiger " + thresholdValue + " °C");
            Thread.Sleep(2500);
            Console.Clear();
        }

    }
    // Metod för att få fram de vanligaste temperaturen i Maj och skriva ut.
    public static void GetMostCommonTemp(CalcTemp[] array)
    {
        // initierar "mostCommonTemp" med första temperaturen i arrayen.
        int mostCommonTemp = array[0].Temp;
        // initierar "maxCount" till 1 = första tempen förekommer 1 gång direkt.
        int maxCount = 1;
        // Yttre loop som går igenom varje element/objekt i arrayen
        for (int i = 0; i < array.Length; i++)
        {
            // nollställer räknaren för varje element
            int count = 1;
            // Inre loop som startar och går igenom resten av arrayen/objekten (i+1)
            for (int j = (i + 1); j < array.Length; j++)
            {
                // Om temp array[i] == array[j] ökar "count" med 1.
                if (array[i].Temp == array[j].Temp)
                {
                    count = count + 1;
                }
            }
            // Om "count" är större än "maxCount" uppdateras både "maxCount" och "mostCommonTemp"
            if (count > maxCount)
            {
                maxCount = count;
                mostCommonTemp = array[i].Temp;
            }
        }
        Console.WriteLine("Den vanligaste temeraturen i maj var " + mostCommonTemp + " °C");
    }

    public static void DayBeforeAfter(CalcTemp[] array, int userDay)
    {
        
        Console.WriteLine("Skriv en Dag för att visa dagen före och efter:");
        int userDayBeforeAfter = int.Parse(Console.ReadLine());
        
        int userDayIndex = userDayBeforeAfter - 1;

        int previousDay = array[userDayIndex - 1].Day;
        int previousTemp = array[userDayIndex - 1].Temp;
        int nextDay = array[userDayIndex + 1].Day;
        int nextTemp = array[userDayIndex + 1].Temp;
        
        Console.Clear();
        Console.WriteLine(previousDay + " Maj: " + previousTemp + " °C");
        Console.WriteLine(userDayBeforeAfter + " Maj: " + array[userDayIndex].Temp + " °C");
        Console.WriteLine(nextDay + " Maj: " + nextTemp + " °C");
    }




}