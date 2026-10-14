string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá pismená, takže program pokračuje při zadání "a" a "A"
// Jakýkoli jiný vstup program ukonči

while (again.ToLower() == "a")
{
    // Vymazání obrazovky
    Console.Clear();

    //Hlavička programu
    Console.WriteLine("*******************************");
    Console.WriteLine("*******************************");
    Console.WriteLine("************Výpis řady*********");
    Console.WriteLine("*******************************");
    Console.WriteLine("*******************************");
    Console.WriteLine("************Sofiia Dron********");
    Console.WriteLine("*******************************");

    //Vstup počateční hodnoty

    Console.Write("Zadejte první číslo řady (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řády znovu: ");
    }

    //Náčtení koncové hodnoty řady

    Console.Write("Zadejte poslední číslo řady (celé číslo): ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo řády znovu: ");
    }


    //Načtení diference s kontrolou kladného nenulového čísla

    Console.Write("Zadejte diferenci (kladné celé číslo): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step) || step <= 0)
    {
        Console.Write("Nezadali jste celé kladné číslo. Zadejte diferenci znovu: ");
    }

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}