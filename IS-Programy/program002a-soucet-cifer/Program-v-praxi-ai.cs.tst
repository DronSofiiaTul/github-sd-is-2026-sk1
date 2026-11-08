
//Luhnov algoritmus se používá například při kontrole formální správnosti čísel platebních karet.
//Když člověk zadává číslo platební karty při online platbě, systém může pomocí tohoto algoritmu zkontrolovat, zda číslo splňuje určité matematické pravidlo.
//Algoritmus dokáže odhalit některé chyby při zadávání čísla, například překlep nebo vynechanou číslici.

//2. Jak algoritmus funguje?
//Luhnov algoritmus pracuje s číslicemi zprava doleva.

//Postup:
//1. Začneme poslední číslicí čísla.
//2. Každou druhou číslici vynásobíme dvěma, počínaje druhou číslicí zprava.
//3. Pokud je výsledek větší než 9, odečteme od něj 9.
//4. Všechny upravené číslice sečteme.
//5. Pokud je výsledný součet dělitelný deseti, číslo splňuje kontrolní podmínku.







Console.WriteLine("*******************************");
Console.WriteLine("     Luhnova kontrola čísla");
Console.WriteLine("*******************************");
Console.WriteLine();

// Zadání testovacího čísla
Console.Write("Zadejte testovací číselný kód: ");
string number = Console.ReadLine() ?? "";

// Kontrola správnosti vstupu
bool valid = number.Length > 0;

foreach (char character in number)
{
    if (!char.IsDigit(character))
    {
        valid = false;
    }
}

if (!valid)
{
    Console.WriteLine("Neplatný vstup. Zadejte pouze číslice.");
}
else
{
    // Příprava proměnných
    int sum = 0;
    bool doubleDigit = false;

    // Procházení čísla zprava doleva
    for (int i = number.Length - 1; i >= 0; i--)
    {
        // Převod znaku na celé číslo
        int digit = int.Parse(number[i].ToString());

        // Každou druhou číslici vynásobíme dvěma
        if (doubleDigit)
        {
            digit = digit * 2;

            // Pokud je výsledek větší než 9, odečteme 9
            if (digit > 9)
            {
                digit = digit - 9;
            }
        }

        // Přičtení číslice k celkovému součtu
        sum = sum + digit;

        // Změna příznaku pro další číslici
        doubleDigit = !doubleDigit;
    }

    // Výpis výsledku
    Console.WriteLine();
    Console.WriteLine("===============================");
    Console.WriteLine($"Kontrolní součet: {sum}");

    if (sum % 10 == 0)
    {
        Console.WriteLine("Číslo splňuje Luhnovu kontrolní podmínku.");
    }
    else
    {
        Console.WriteLine("Číslo nesplňuje Luhnovu kontrolní podmínku.");
    }

    Console.WriteLine("===============================");
}
