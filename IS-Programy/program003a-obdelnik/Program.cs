using System;
using System.Diagnostics.CodeAnalysis;

string again = "a";

//Řídicí cyklus aplikace
while (again.ToLower() == "a")
{
    Console.Clear();

    Console.WriteLine("********************************");
    Console.WriteLine("***** Vykreslení obdélníku *****");
    Console.WriteLine("********************************");
    Console.WriteLine();

    //Zadání šířky

    Console.Write("Zadejte šířku obdélníku: ");
    int width;

    while (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Chyba! Zadejte kladné čelé číslo: ");
        Console.ResetColor();
    }

    //Zadání výšky
    Console.Write("Zadejte výšku odbélníku: ");
    int height;

    while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Chyba! Zadejte kladné čelé číslo: ");
        Console.ResetColor();
    }

    Console.WriteLine();
    Console.WriteLine($"Vykresluji obdélník {width} x {height}:");
    Console.WriteLine();

    //Vykreslení odbélníku pomocí vnořených cyklů

    for (int i = 1; i <= height; i++)
    {
        for (int j = 1; j <= width; j++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
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
