string again = "a";

// Řídicí cyklus aplikace:
// .ToLower() převede vstup na malá písmena, takže program pokračuje při zadání 'a' i 'A'.
// Jakýkoliv jiný vstup program ukončí.
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("***** Ciferný součet *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Tomáš Žižka ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

    // 1. Vstup prvnihodnoty
    Console.Write("Zadejte celé čislo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo znovu: ");
    }





    // 4. Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Zadané číslo: {number}");
    Console.WriteLine("====================================");
    Console.WriteLine();

    //Zde budeme pokračovat konkrétním algoritmem

    //Příprava pomocných proměnných pro výpočet
    int numberBackup = number;
    int sum = 0; //Neutřální hodnota pro sčítání je 0
    int digit;   //Proměnná pro uložení právě zjištěné číslice
    int multiplication = 1;

    //Ošetření záporných čísel (znamenko nemá vliv na číslice)

    if (number < 0)
    {
        number = -number;
    }

    //Zvláštní případ pro nulu
    if (number == 0)
    {
        sum = 0;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Průběh rozkladu čísla na číslice");


        //Matematický rozklad čísla pomocí cyklu
        //Využíváme operaci modulo - určení zbytku po celočíselném dělení
        while (number > 0)
        {
            digit = number % 10; //Modulo 10 -
            sum = sum + digit;  //Příčtení číslice k celkovému součtu
            Console.WriteLine($"Získaná číslice: {digit}");
            number = number / 10; //Celočíselné dělení 10 odstraní poslední číslici

            multiplication = multiplication * digit;
        }
    }

    //Výpis výsledku

    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Součet číslic čísla {numberBackup} je {sum} ");
    Console.WriteLine($"Součin číslic čísla {numberBackup} je {multiplication}");
    Console.WriteLine("====================================");

    // 6. Dotaz na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}