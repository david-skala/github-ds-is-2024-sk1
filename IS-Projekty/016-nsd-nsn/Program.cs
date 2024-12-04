using System;

class Program {
    static void Main() {

        string again = "a";

        while(again == "a") {

        razitko();

        ulong a = nacistCislo("Zadejte číslo A: ");
        ulong b = nacistCislo("Zadejte číslo B: ");

        ulong nsd = vypocitatNSD(a, b);
        ulong nsn = vypocitatNSN(a, b, nsd);

        zobrazitVysledky(a, b, nsd, nsn);

        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }

        static void razitko() {
        Console.Clear();
        Console.WriteLine("**************************");
        Console.WriteLine("******* NSD a NSN ********");
        Console.WriteLine("**************************");
        Console.WriteLine("****** David Skála *******");
        Console.WriteLine("**************************");
        Console.WriteLine();
        }

        static ulong nacistCislo(string zprava) {
            Console.Write(zprava);
            ulong cislo;
            while(!ulong.TryParse(Console.ReadLine(), out cislo)) {
            Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
        }
        return cislo;
        }

        static ulong vypocitatNSD(ulong a, ulong b) {
            while (a != b) {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        static ulong vypocitatNSN(ulong a, ulong b, ulong nsd) {
            return (a*b)/nsd;
        }

        static void zobrazitVysledky(ulong a, ulong b, ulong nsd, ulong nsn) {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("NSD čísel: {0} a {1} je {2}", a, b, nsd);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"NSN čísel: {a} a {b} je {nsn}");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
