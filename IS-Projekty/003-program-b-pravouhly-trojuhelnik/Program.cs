﻿using System.Globalization;

string again = "a";

        while(again == "a") {

        Console.Clear();
        Console.WriteLine("**************************");
        Console.WriteLine("******** Obdelník ********");
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

        for(int i = 1; i <= height; i++) {
            for(int j = 1; j <= i; j++) {
                Console.Write("* ");
                System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100));
            }

            Console.WriteLine();

        }

        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }