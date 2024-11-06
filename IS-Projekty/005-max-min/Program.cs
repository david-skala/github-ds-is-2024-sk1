using System.Globalization;

string again = "a";

        while(again == "a") {

        Console.Clear();
        Console.WriteLine("*******************************************");
        Console.WriteLine("************ MAXIMUM A MINIMUM ************");
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

        Console.WriteLine("\n\nNáhodná čísla:");
        for(int i = 0; i < n; i++) {
            myArray[i] = randomNumber.Next(dm, hm + 1);
            Console.Write("{0}; ", myArray[i]);
        }

        int max = myArray[0];
        int min = myArray[0];
        int pmax = 0;
        int pmin = 0;

        for(int i = 1; i < n; i++) {
            if(myArray[i] > max) {
                max = myArray[i];
                pmax = i;
            }
            else if(myArray[i] < min) {
                min = myArray[i]
                pmin = i;
            }
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Maximum z vygenerovaných čísel: {0}, na pozici {1}.", max, pmax);
        Console.WriteLine("Minimum z vygenerovaných čísel: {0}, na pozici {1}.", min, pmin);

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }