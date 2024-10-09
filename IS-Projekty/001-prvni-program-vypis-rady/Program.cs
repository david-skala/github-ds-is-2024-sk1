using System;

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

        // Zadání hodnot do programu -> špatné řešení

        /* Console.Write("Zadejte první číslo řady: ");
        int first = int.Parse(Console.ReadLine()); */

        // Zadání hodnot do programu -> správné řešení

        Console.Write("Zadejte první číslo řady: ");
        int first;
        while(!int.TryParse(Console.ReadLine(), out first)) {
            Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
        }

        Console.Write("Zadejte poslední číslo řady: ");
        int last;
        while(!int.TryParse(Console.ReadLine(), out last)) {
            Console.Write("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu: ");
        }

        Console.Write("Zadejte diferenci mezi čísly: ");
        int step;
        while(!int.TryParse(Console.ReadLine(), out step)) {
            Console.Write("Nezadali jste celé číslo. Zadejte diferenci mezi čísly znovu: ");
        }

        // Výpis řady

        Console.WriteLine();
        int current = first;
        while(current <= last) {
            Console.WriteLine(current);
            current = current + step;   // Pričtení diference
        }

        // Výpis zadaných hodnot
        
        Console.WriteLine();
        Console.WriteLine("Zadali jste tyto hodnoty: ");
        Console.WriteLine("První číslo řady: {0}", first);
        Console.WriteLine("Poslední číslo řady: {0}", last);
        Console.WriteLine("Diference mezi čísly: {0}", step);

        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }
    }
}

// jednoradkovy komentar

/* vice radkovy
komentar Shift+Alt+A */
