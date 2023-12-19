
using _150_AbstractClass;

class Programm
{
    static void Main()
    {
        // Versuch, ein Objekt der abstrakten Klasse Roboter zu erstellen
        // Roboter meinRoboter = new Roboter(); // Dies führt zu einem Kompilierfehler

        // Erstellen eines Humanoid-Objekts
        Humanoide meinHumanoide = new Humanoide
        {
            Hersteller = "RoboCorp",
            KünstlicheIntelligenzStufe = 3
        };

        // Aufruf der Methoden und Eigenschaften, die von Roboter geerbt wurden
        meinHumanoide.Aktivieren(); // Geerbte und überschriebene Methode
        meinHumanoide.Anzeigen();   // Geerbte Methode

        // Anzeigen der geerbten und überschriebenen Eigenschaften
        Console.WriteLine($"Modell: {meinHumanoide.Modell}"); // Geerbte und überschriebene Eigenschaft
        Console.WriteLine($"Hersteller: {meinHumanoide.Hersteller}"); // Geerbte Eigenschaft
    }
}