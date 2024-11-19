using System.Globalization;
using System.Diagnostics;

string again = "a";

        while(again == "a") {

        Console.Clear();
        Console.WriteLine("*******************************************");
        Console.WriteLine("******** GENERÁTOR NÁHODNÝCH ČÍSEL ********");
        Console.WriteLine("*******************************************");
        Console.WriteLine("*************** David Skála ***************");
        Console.WriteLine("*******************************************");
        Console.WriteLine();

        Console.Write("Zadejte počet generovaných čísel:");
        int n;
        while(!int.TryParse(Console.ReadLine(), out n)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
        }

        Console.Write("Zadejte dolní mez:");
        int dm;
        while(!int.TryParse(Console.ReadLine(), out dm)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
        }

        Console.Write("Zadejte horní mez:");
        int hm;
        while(!int.TryParse(Console.ReadLine(), out hm)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
        }

        Console.WriteLine();
        Console.WriteLine("*******************************************");
        Console.WriteLine("Zadané hodnoty:");
        Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez {2}", n, dm, hm);
        Console.WriteLine("*******************************************");
        Console.WriteLine();

        // Deklarace pole

        int[] myArray = new int[n];

        Random randomNumber = new Random();

        Console.WriteLine("\nNáhodná čísla:");
        for(int i = 0; i < n; i++) {
            myArray[i] = randomNumber.Next(dm, hm + 1);
            Console.Write("{0}; ", myArray[i]);
        }

        int CompareCount = 0;
        int ChangeCount = 0;

        for (int i = 0; i < n - 1; i++) {
        int maxIndex = i;
        for (int j = i + 1; j < n; j++) {
        CompareCount++;
        if (myArray[j] > myArray[maxIndex]) {
            maxIndex = j;
        }
        }
   
        if (maxIndex != i) {
        int pom = myArray[i];
        myArray[i] = myArray[maxIndex];
        myArray[maxIndex] = pom;
        ChangeCount++;
        }
        }

        Console.WriteLine("\nSeřazené pole:");
        for(int i = 0; i < n; i++) {
            Console.Write("{0}; ", myArray[i]);
        }

        Console.WriteLine("\nPočet porovnání: {0}, počet změn pořadí: {1}.", CompareCount, ChangeCount);
        Console.ResetColor();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }