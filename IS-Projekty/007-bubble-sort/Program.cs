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

        Stopwatch myStopwatch = new Stopwatch();

        int CompareCount = 0;
        int ChangeCount = 0;

        myStopwatch.Start();
        for(int i = 0; i < n-1; i++) {
            for(int j = 0; j < n-i-1; j++) {
                CompareCount++;
                if(myArray[j] < myArray[j+1]) {
                    int pom = myArray[j+1];
                    myArray[j+1] = myArray[j];
                    myArray[j] = pom;
                    ChangeCount++;
                }
            }
        }
        myStopwatch.Stop();

        Console.WriteLine("\nSeřazené pole:");
        for(int i = 0; i < n; i++) {
            myArray[i] = randomNumber.Next(dm, hm + 1);
            Console.Write("{0}; ", myArray[i]);
        }

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine("\nDoba trvání řadícího cyklu bubble sort: {0}.", myStopwatch.Elapsed);
        Console.WriteLine("\nPočet porovnání: {0}, počet změn pořadí: {1}.", CompareCount, ChangeCount);
        Console.ResetColor();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }