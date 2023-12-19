using _020_AutoProperties;

class Program
{
    static void Main()
    {
        // Erstellen einer Instanz von Auto
        Auto meinAuto = new Auto();

        // Setzen der Anzahl der Sitzplätze
        meinAuto.AnzahlSitzplaetze = 5;

        // Auslesen und Anzeigen der Anzahl der Sitzplätze
        Console.WriteLine("Anzahl der Sitzplätze im Auto: " + meinAuto.AnzahlSitzplaetze);
    }
}