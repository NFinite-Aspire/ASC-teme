using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Conversie Binar -> Hexadecimal ===");

        Console.Write("Introduceți numărul binar: ");
        string bin = Console.ReadLine();

        string hex = BinaryToHex(bin);
        Console.WriteLine("Rezultatul în baza 16: " + hex);

        Console.WriteLine("Apasă Enter pentru a închide...");
        Console.ReadLine(); // oprește fereastra consolei
    }

    static string BinaryToHex(string bin)
    {
        if (string.IsNullOrWhiteSpace(bin))
            return "0"; // dacă inputul e gol sau doar spații, returnăm 0

        // separare partea întreagă și fracționară
        string[] parts = bin.Split('.');
        string intPart = parts[0];
        string fracPart = parts.Length > 1 ? parts[1] : "";

        // verificare caractere valide
        foreach (char c in intPart + fracPart)
            if (c != '0' && c != '1')
                return "Input invalid!"; // doar 0 și 1 permise

        // completare partea întreagă la multiplu de 4
        while (intPart.Length % 4 != 0)
            intPart = "0" + intPart;

        // completare partea fracționară la multiplu de 4
        while (fracPart.Length % 4 != 0 && fracPart.Length > 0)
            fracPart += "0";

        string result = "";

        // conversie partea întreagă
        for (int i = 0; i < intPart.Length; i += 4)
        {
            string group = intPart.Substring(i, 4);
            result += Convert.ToInt32(group, 2).ToString("X");
        }

        // eliminare zero la început (dacă există)
        result = result.TrimStart('0');
        if (string.IsNullOrEmpty(result))
            result = "0";

        // conversie partea fracționară
        if (!string.IsNullOrEmpty(fracPart))
        {
            result += ".";
            for (int i = 0; i < fracPart.Length; i += 4)
            {
                string group = fracPart.Substring(i, 4);
                result += Convert.ToInt32(group, 2).ToString("X");
            }
        }

        return result; // întotdeauna returnează string
    }
}
