using System.Globalization;

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

        // Deklarace pole - Generátor

        int[] myArray = new int[n];

        Random randomNumber = new Random();

        Console.WriteLine("Náhodná čísla:");
        int sum = 0;
        for(int i = 0; i < n; i++) {
            myArray[i] = randomNumber.Next(dm, hm + 1);
            Console.Write("{0}; ", myArray[i]);
            sum += myArray[i]; // Přičítání každého čísla do součtu
        }

        // Maximum a minimum

        int maximum = myArray[0];
        int minimum = myArray[0];
        int poziceMax = 0;
        int poziceMin = 0;

        for (int i = 1; i < n; i++) {
            if (myArray[i] > maximum) {
                maximum = myArray[i];
                poziceMax = i;
            }
            else if (myArray[i] < minimum) {
                minimum = myArray[i];
                poziceMin = i;
            }
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Maximum z vygenerovaných čísel: {0}, na pozici {1}.", maximum, poziceMax);
        Console.WriteLine("Minimum z vygenerovaných čísel: {0}, na pozici {1}.", minimum, poziceMin);

        // Aritmetický průměr

        double average = (double)sum / n;  // Spočítáme průměr

        // Získáme celočíselnou část a zbytek
        int integerPart = (int)average;  // Celočíselná část průměru
        int remainder = (int)((average - integerPart) * 100);  // Zbytek v setinách

        Console.WriteLine();
        Console.WriteLine("Aritmetický průměr: {0}", average);
        Console.WriteLine("Celočíselná část průměru: {0}", integerPart);
        Console.WriteLine("Zbytek průměru (v setinách): {0}", remainder);


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }