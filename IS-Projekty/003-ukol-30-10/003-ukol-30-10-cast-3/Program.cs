using System.Globalization;

string again = "a";

        while(again == "a") {

        Console.Clear();
        Console.WriteLine("**************************");
        Console.WriteLine("****** Úkol výpis 3 ******");
        Console.WriteLine("**************************");
        Console.WriteLine("****** David Skála *******");
        Console.WriteLine("**************************");
        Console.WriteLine();

        // Zadání hodnot do programu

        Console.Write("Zadejte výšku obrazce (celé číslo): ");
        int height;
        while(!int.TryParse(Console.ReadLine(), out height)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu výšku obrazce: ");
        }

        for (int i = height; i >= 1; i--) {
        for (int j = 1; j <= height - i; j++) {
        Console.Write("  ");
        }

        for (int j = 1; j <= (2 * i - 1); j++) {
        Console.Write("* ");
        }

        Console.WriteLine();
        }

        for (int k = 2; k <= height; k++) {
        for (int j = 1; j <= height - k; j++) {
        Console.Write("  ");
        }

        for (int j = 1; j <= (2 * k - 1); j++) {
        Console.Write("* ");
        }

        Console.WriteLine();
        }   

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }   