using System;

class Program {
    static void Main() {

        string again = "a";

        while(again == "a") {

        Console.Clear();
        Console.WriteLine("***************************");
        Console.WriteLine("****** ANALÝZA TEXTU ******");
        Console.WriteLine("***************************");
        Console.WriteLine("******* David Skála *******");
        Console.WriteLine("***************************");
        Console.WriteLine();

        Console.WriteLine("Zadejte váš text: ");
        string myText = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(myText);

        // Výpis prvního písmena:
        Console.WriteLine(myText[0]);

        // Výpis délky textu:
        Console.WriteLine(myText.Length);

        string samohlasky = "aáeéěiíoóuůúyý";
        string souhlasky = "bcdďfghjklmnňpqrřsštťvwxzž";
        string cislice = "0123456789";

        int pocSamohlasek = 0;
        int pocSouhlasek = 0;
        int pocCislic = 0;
        int pocOstatnich = 0;

        foreach(char znak in myText) {
            if (souhlasky.Contains(znak)) {
                pocSouhlasek++
            } 
            else if (samohlasky.Contains(znak)) {
                pocSamohlasek++
            }
            else if (cislice.Contains(znak)) {
                pocCislic++
            }
            else {
                pocOstatnich++
            }
        }

        Console.WriteLine();
        Console.WriteLine("Počet souhlásek: {0}, samohlásek {1},", pocSouhlasek, pocSamohlasek);
        Console.WriteLine("číslic: {0}, ostatních {1}.", pocCislic, pocOstatnich)

        Console.WriteLine();
        Console.WriteLine("Pro opakování programu stiskněte klávesu a");
        again = Console.ReadLine();

        }
    }
}