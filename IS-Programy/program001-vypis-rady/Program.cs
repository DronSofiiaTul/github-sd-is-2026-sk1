string again = "a";

// Řídící cyklus programu
// ToLower() převede vstup na malá pismená, takže program pokračuje při zadání "a" a "A"
// Jakýkoli jiný vstup program ukonči

while (again.ToLower() == "a")
{



    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte klávesu a. Následně potvrďte klávesou Enter");
    again = Console.ReadLine() ?? "";
}