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
    string numberText = number.ToString();
    int sum = 0; //Neutřální hodnota pro sčítání je 0
    int multiplication = 1;



    //Zde alrgoritmus pomoci string

    foreach (char character in numberText)
    {

        if (character != '-')
        {
            int numberDigit = int.Parse(character.ToString());

            sum = sum + numberDigit;
            multiplication = multiplication * numberDigit;
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