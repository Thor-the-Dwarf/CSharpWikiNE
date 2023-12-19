namespace _150_AbstractClass;

// Abstrakte Klasse Roboter
public abstract class Roboter
{
    // Abstrakte Eigenschaft
    public abstract string Modell { get; }

    // Konkrete Eigenschaft
    public string Hersteller { get; set; }

    // Abstrakte Methode
    public abstract void Aktivieren();

    // Konkrete Methode
    public void Anzeigen()
    {
        Console.WriteLine($"Robotermodell: {Modell}, Hersteller: {Hersteller}");
    }
}

// Konkrete Klasse Humanoid, die von Roboter erbt
public class Humanoide : Roboter
{
    public int KünstlicheIntelligenzStufe { get; set; }

    public override string Modell => "Humanoid";

    public override void Aktivieren()
    {
        Console.WriteLine("Humanoider Roboter aktiviert.");
    }
}