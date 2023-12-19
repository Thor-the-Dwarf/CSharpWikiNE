public class Programm
{
    public static void Main(string[] args)
    {
        Motorrad motorrad = new Motorrad();
        Console.WriteLine(motorrad.anzahlRaeder);
        Console.WriteLine(Motorrad.counter);        // Statisches wird mit vererbt
        motorrad.starteMotor();
        Console.WriteLine(motorrad.kennummer);
        motorrad.klappeStaenderaus();
        
        Fahrzeug fahrzeug = new Fahrzeug();
        Console.WriteLine(fahrzeug.anzahlRaeder);
        fahrzeug.starteMotor();
        // Console.WriteLine(fahrzeug.kennummer);   // Elternklassen kommen nicht an die Attribute ihrer Erweiterungen heran
        // fahrzeug.klappeStaenderaus();            // Basisklassen kommen nicht an die Methoden ihrer Erweiterungen heran
        
    }
}

class Fahrzeug
{
    public static int counter = 0;
    public int anzahlRaeder = 2;

    public void starteMotor() {
        Console.WriteLine("Motor gestartet");
    }
}

class Motorrad : Fahrzeug
{
    // die erbende Klasse erweitert die Basisklasse/Elternklasse
    // sie verfügt über alles was die Basisklasse/Elternklasse auch hat
    public int kennummer = 123456;

    public void klappeStaenderaus()
    {
        Console.WriteLine("Ständer ausgeklappt");
    }
}