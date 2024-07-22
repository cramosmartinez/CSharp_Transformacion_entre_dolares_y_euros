class CurrencyConverter
{
    static void Main()
    {
        Console.WriteLine("Seleccione la opción:");
        Console.WriteLine("1- Convertir de dólares a euros");
        Console.WriteLine("2- Convertir de euros a dólares");

        int option = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el tipo de cambio del día: ");
        double exchangeRate = double.Parse(Console.ReadLine());

        if (option == 1)
        {
            Console.Write("Ingrese la cantidad en dólares: ");
            double dollars = double.Parse(Console.ReadLine());
            double euros = ConvertDollarsToEuros(dollars, exchangeRate);
            Console.WriteLine($"{dollars} dólares son {euros:F2} euros.");
        }
        else if (option == 2)
        {
            Console.Write("Ingrese la cantidad en euros: ");
            double euros = double.Parse(Console.ReadLine());
            double dollars = ConvertEurosToDollars(euros, exchangeRate);
            Console.WriteLine($"{euros} euros son {dollars:F2} dólares.");
        }
        else
        {
            Console.WriteLine("Opción no válida.");
        }
    }

    static double ConvertDollarsToEuros(double dollars, double exchangeRate)
    {
        return dollars * exchangeRate;
    }

    static double ConvertEurosToDollars(double euros, double exchangeRate)
    {
        return euros / exchangeRate;
    }
}
