using System;

class Program
{
    static void Main()
    {
        string again = "a";

        while (again == "a") 
        {
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("******** GENERÁTOR ARITMETICKÉ POLOUPNOSTI ********");
            Console.WriteLine("*******************************************");
            Console.WriteLine("*************** David Skála ***************");
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            Console.Write("Zadejte počet čísel: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n)) 
            {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
            }

            Console.Write("Zadejte diferencí (mezi jednotlivými čísly): ");
            int d;
            while (!int.TryParse(Console.ReadLine(), out d)) 
            {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
            }

            Console.Write("Zadejte první prvek posloupnosti: ");
            int a;
            while (!int.TryParse(Console.ReadLine(), out a)) 
            {
                Console.Write("Nezadali jste celé číslo. Zadejte znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("*******************************************");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; Diference: {1}; První prvek posloupnosti: {2}", n, d, a);
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            int sum = 0;

            Console.WriteLine("Aritmetická posloupnost:");
            for (int i = 0; i < n; i++) 
            {
                int prvek = a + i * d; // Vypočítání aktuálního prvku posloupnosti
                Console.Write(prvek + "; ");
                sum += prvek; // Přičítání aktuálního prvku k součtu
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Součet zobrazených čísel: " + sum);
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }
    }
}
