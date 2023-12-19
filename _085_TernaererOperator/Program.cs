class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ternärer Operator (Boolean) ? (True) : (False)");
        Console.WriteLine("Gib eine Zahl ein:");
        int zahl1 = Convert.ToInt32(Console.ReadLine());

        // Der ternäre Operator besteht aus drei Teilen: Bedingung ? WertWennWahr : WertWennFalsch
        // Er wird verwendet, um einfache if-else-Entscheidungen in einer Zeile zu schreiben.
        string ergebnis1 = zahl1 > 0 
            ? "Positiv" 
            : "Nicht positiv";

        Console.WriteLine("Die Zahl ist " + ergebnis1);

        Console.WriteLine("Ternärer Operator verschachtelt");
        Console.WriteLine("(Boolean1) ? (Boolean2) ? (True2) : (False2) : (False1)");
        Console.WriteLine("Gib eine Zahl ein:");
        int zahl2 = Convert.ToInt32(Console.ReadLine());

        // Verschachtelter ternärer Operator: Mehrere Bedingungen in einer Zeile
        // Der äußere ternäre Operator überprüft, ob die Zahl größer als 0 ist.
        // Der innere ternäre Operator (in den Ausdrücken des äußeren Operators) überprüft, ob die Zahl gerade ist.
        string ergebnis2 = zahl2 > 0 
            ? (zahl2 % 2 == 0 
                ? "Positiv und gerade" 
                : "Positiv und ungerade") 
            : "Nicht positiv";

        Console.WriteLine("Ergebnis: " + ergebnis2);
    }
}