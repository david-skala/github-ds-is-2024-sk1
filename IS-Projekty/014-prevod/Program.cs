using System;
using System.Resources;

class Program {
    static void Main() {

        string again = "a";

        while(again == "a") {

        Console.Clear();
        Console.WriteLine("**************************");
        Console.WriteLine("**** Výpis řady čísel ****");
        Console.WriteLine("**************************");
        Console.WriteLine("****** David Skála *******");
        Console.WriteLine("**************************");
        Console.WriteLine();

        Console.Write("Zadejte přirozené číslo v desítkové soustavě: ");
        uint cislo;
        while(!uint.TryParse(Console.ReadLine(), out cislo)) {
            Console.Write("Nezadali jste správné číslo. Zadejte přirozené číslo v desítkové soustavě: ");
        }
        
        uint[] MyArray = new uint[32];
        uint zaloha = cislo;
        uint zbytek;

        uint i;
        for (i = 0; cislo > 0; i++) {
            zbytek = cislo % 2;
            cislo = (cislo - zbytek)/2;
            MyArray[i] = zbytek;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Celá část = {0}; Zbytek = {1}.", cislo, zbytek);
        }

        Console.WriteLine("Poslední využitá buňka pole: {0}.", i-1);
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        Console.WriteLine("Výsledek: ");
        for (uint j = i-1; j >= 0; j--) {
            Console.Write("{0}", MyArray[j]);
        }

        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }
    }
}