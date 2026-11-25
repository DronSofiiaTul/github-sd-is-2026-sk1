using System;
using System.Data;

string again = "a";

// Řídicí cyklus aplikace:
// .ToLower() převede vstup na malá písmena, takže program pokračuje při zadání 'a' i 'A'.
// Jakýkoliv jiný vstup program ukončí.
while (again.ToLower() == "a")
{
    Console.Clear();
    Console.WriteLine("*************************************");
    Console.WriteLine("***Generátor -  max, min, hodiny***");
    Console.WriteLine("*************************************");
    Console.WriteLine("******* ***Sofiia Dron ***************");
    Console.WriteLine("*************************************");
    Console.WriteLine();

    // 1. Počet generovaných čísel (větší než nula)
    Console.Write("Zadejte počet generovaných čísel (přírozené číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        Console.Write("Nezadali jste přírozené číslo. Zadejte počet čísel znovu: ");
    }

    // 2. Načtení dolní meze
    Console.Write("Zadejte dolní meze (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    // 2. Načtení horní meze
    Console.Write("Zadejte horní mez (celé číslo větší nebo rovno hodnotě dolní meze): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound) || upperBound < lowerBound)
    {
        Console.Write("Nezadali jste celé číslo větší nebo rovno hodnotě dolní meze. Zadejte horní mez znovu: ");
    }



    // 4. Rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Počet čísel: {n}; Dolní mez: {lowerBound}; Horní mez: {upperBound}");
    Console.WriteLine("====================================");
    Console.WriteLine();

    //Zde budeme pokračovat konkrétním algoritmem
    //Deklarace pole a alokace pole v paměti 
    int[] myRandNumbs = new int[n];

    //Inicializace generátoru náhodnýchh čísel
    Random myRandNumb = new Random();
    // Random myRandNumb = new Random(50); 

    //Generování náhodných čísel a jejích uložení do pole
    Console.WriteLine("Vygenerovaná pseudonáhodná čísla: ");
    for (int i = 0; i < myRandNumbs.Length; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write($"{myRandNumbs[i]}; ");
    }

    int max = myRandNumbs[0];
    int min = myRandNumbs[0];
    int posMax = 0;
    int posMin = 0;

    //Tady bude 1 protoře to budeme porovnavát s [1], není smysly porovnavát [0] s [0]

    for (int i = 1; i < n; i++)
    {
        //zjišťujeme zda i-tý prvek není větší než aktuální hodnota maxima
        if (myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
            posMax = i;
        }
        //zjišťujeme zda i-tý prvek není menší než aktuální hodnota manima
        if (myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    }




    Console.WriteLine();
    Console.WriteLine("====================================");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice prvního maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice prvního manima: {posMin}");
    Console.WriteLine("====================================");
    Console.WriteLine();



    // 6. Dotaz na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stiskněte 'a' a potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}