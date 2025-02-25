namespace C__Basic_Oppgave_1_Programflyt;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the temperature: ");
        string input = Console.ReadLine() ?? "";

        if (int.TryParse(input, out int temperature))
        {
            if (temperature < 10)
            {
                Console.WriteLine("It's cold!");
            }
            else if (temperature <= 25)
            {
                Console.WriteLine("It's warm!");
            }
            else
            {
                Console.WriteLine("It's hot!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}

