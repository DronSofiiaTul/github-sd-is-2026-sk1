using System;

string again = "a";

Random randomNumber = new Random();

//Řídicí cyklus aplikace
while (again.ToLower() == "a")
{
    Console.Clear();

    Console.WriteLine("********************************");
    Console.WriteLine("***** Generování náhodných čísel *****");
    Console.WriteLine("********************************");
    Console.WriteLine();

    //Dotáz na počet čísel, které chceme vygenerovát

    Console.Write("Zadejte počet čísel: ");
    int coutn;

    while (!int.TryParse(Console.ReadLine(), out coutn) || coutn <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Chyba! Zadejte kladné celé číslo");
        Console.ResetColor();
    }

    //Zadání dolní meze
    Console.WriteLine();
    Console.Write("Zadejté dolní mez: ");
    int dm;

    while (!int.TryParse(Console.ReadLine(), out dm))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Chyba! Zadejte celé číslo: ");
        Console.ResetColor();
    }

    //Zadání horní meze
    Console.WriteLine();
    Console.Write("Zadjete horní mez: ");
    int hm;

    while (!int.TryParse(Console.ReadLine(), out hm) || hm < dm)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Chyba! Zadejte celé číslo: ");
        Console.ResetColor();
    }

    //Vytvoření pole
    int[] numbers = new int[coutn];

    //Generování pseudonáhodných čísel a jejich ukládání do pole
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = randomNumber.Next(dm, hm + 1);
    }

    //Výpis všech vygenerovaných čísel
    Console.WriteLine();
    Console.Write("Vygenerovaná čísla: ");
    Console.WriteLine();

    for (int i = 0; i < numbers.Length; i++)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{numbers[i]} ");
    }

    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine();

    //Kladná, záporná a nula
    int positive = 0;
    int negative = 0;
    int zero = 0;

    //Sudá a lichá čísla
    int even = 0;
    int odd = 0;

    //Třídění čísel
    for (int i = 0; i < numbers.Length; i++)
    {
        //Podle znaménka
        if (numbers[i] > 0)
        {
            positive++;
        }
        else if (numbers[i] < 0)
        {
            negative++;
        }
        else
        {
            zero++;
        }

        //Suda a lichá
        if (numbers[i] % 2 == 0)
        {
            even++;
        }
        else
        {
            odd++;
        }

    }

    Console.WriteLine($"Počet kladných čísel: {positive}");
    Console.WriteLine($"Počet záporných čísel: {negative}");
    Console.WriteLine($"Počet nulových čísel: {zero}");

    Console.WriteLine();

    Console.WriteLine($"Počet sudých čísel: {even}");
    Console.WriteLine($"Počet lichých čísel: {odd}");


    //Dotaz na oopakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a':");
    again = Console.ReadLine() ?? "";
}
