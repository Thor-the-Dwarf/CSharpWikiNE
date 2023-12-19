class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Gib eine Zahl zwischen 1 und 3 ein:");
        string eingabe = Console.ReadLine();
        int zahl = Convert.ToInt32(eingabe);

        // Die switch-Anweisung wird verwendet, um eine der vielen Codeblöcke auszuführen.
        // Sie ist eine Alternative zu einer Reihe von if-else-Anweisungen und ist oft übersichtlicher.
        switch (zahl)
        {
            case 1:
                // Dieser Block wird ausgeführt, wenn 'zahl' den Wert 1 hat.
                Console.WriteLine("Du hast die Zahl Eins gewählt.");
                break; // 'break' beendet die switch-Anweisung.

            case 2:
                Console.WriteLine("Du hast die Zahl Zwei gewählt.");
                break;

            case 3:
                Console.WriteLine("Du hast die Zahl Drei gewählt.");
                break;

            default:
                // 'default' wird ausgeführt, wenn keiner der Fälle zutrifft.
                Console.WriteLine("Ungültige Eingabe.");
                break;
        }

        // Ermutigung, die switch-Anweisung mit eigenen Werten zu testen.
        Console.WriteLine("Versuche, die Anweisung mit anderen Zahlen zu testen!");
    }
}