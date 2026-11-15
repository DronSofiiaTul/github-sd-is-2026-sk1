string again = "a";

//Řídicí cyklus aplikace
while (again.ToLower() == "a")
{
    Console.Clear();

    Console.WriteLine("********************************");
    Console.WriteLine("***** Vykreslení pravoúhlýho trojúhelníku *****");
    Console.WriteLine("********************************");
    Console.WriteLine();

    //Zadání velikosti trojúhelníku

    Console.Write("Zadejte výšku troúhelníku: ");
    int size;

    while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Chyba! Zadejte kladné čelé číslo: ");
        Console.ResetColor();
    }



    Console.WriteLine();
    Console.WriteLine($"Vykresluji troúhledník o výšce {size}:");
    Console.WriteLine();

    //Vykreslení troúhleníku pomoci cyklu

    for (int i = 1; i <= size; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("* ");

            //Zpomalení vykreslování
            System.Threading.Thread.Sleep(100);
        }
        Console.WriteLine();
    }

    //Návrat k původní barvě 
    Console.ResetColor();

    //Dotaz na oopakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a':");
    again = Console.ReadLine() ?? "";
}