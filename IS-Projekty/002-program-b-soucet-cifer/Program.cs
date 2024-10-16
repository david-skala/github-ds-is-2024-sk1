string again = "a";

        while(again == "a") {

        Console.Clear();
        Console.WriteLine("***************************");
        Console.WriteLine("* Ciferný součet a součin *");
        Console.WriteLine("***************************");
        Console.WriteLine("******* David Skála *******");
        Console.WriteLine("***************************");
        Console.WriteLine();

        // Zadání hodnot do programu

        Console.Write("Zadejte celé číslo: ");
        int number;
        while(!int.TryParse(Console.ReadLine(), out number)) {
            Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
        }

        int suma = 0;
        int multi = 1;
        int numberBackup = number;
        int digit;

        do {
        number = -number; // Absolutní hodnota
        } while (number < 0);

        do {
        digit = number % 10;
        number = (number - digit) / 10;
        Console.WriteLine("digit = {0}", digit);
        suma += digit;
        multi *= digit;
        } while (number >= 10);

        Console.WriteLine("digit = {0}", number);
        
        // Přidání poslední cifry
        suma =  suma + number;
        multi = multi * number;

        Console.WriteLine();
        Console.WriteLine("Součet cifer čísla {0} je {1}", numberBackup, suma);
        Console.WriteLine("Součin cifer čísla {0} je {1}", numberBackup, multi);

        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }