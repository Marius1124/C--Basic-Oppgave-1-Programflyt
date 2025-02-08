namespace C__Basic_Oppgave_1_Programflyt;

class Program
{
    static void Main(string[] args)
    {
        // Temperatures are measured in Celsius and not Fahrenheit
        Console.Write("Enter the temperature: ");
        int temperature = Convert.ToInt32(Console.ReadLine());

        // If temperature is below 10 "It's cold"
        if (temperature < 10)
        {
            Console.WriteLine("It's cold!");
        }
        // If temperature is above 10 or below 25 "It's warm"
        else if (temperature >= 10 && temperature <= 25)
        {
            Console.WriteLine("It's warm!");
        }
        // or else above 25 celsius "It's hot"
        else
        {
            Console.WriteLine("It's hot!");
        }
    }
}

