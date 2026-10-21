GuessTheNumber();

static void GuessTheNumber()
{
    Random rnd = new Random();

    int secretNumber = rnd.Next(1, 101);

    var numTries = 0;

    while(true)
    {
        Console.Write("Introduzca un número entero del 1 al 100: ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("No se ha recibido ningún valor.");
            return;
        }

        if (!int.TryParse(input, out int decision))
        {
            Console.WriteLine("Debe introducir un número entero. Inténtelo de nuevo.");
            continue; 
        }

        numTries++;

        if (decision > secretNumber)
        {
            Console.WriteLine("El número secreto es menor.");
        }
        else if (decision < secretNumber)
        {
            Console.WriteLine("El número secreto es mayor.");
        }
        else
        {
            Console.WriteLine($"Correcto. Has necesitado este número de intentos: {numTries}");
            break;
        }
    }
}