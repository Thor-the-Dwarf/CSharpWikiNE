namespace _040_AccesModifier;

public class Auto
{
    public bool MotorLaeuft { get; private set; }
    internal string Wartungszustand { private get;  set; }

    public void DoService()
    {
        this.Wartungszustand = "Einwand frei";
        this.MotorLaeuft = true;
        Console.WriteLine("Der Wartungszustand ist: " + this.Wartungszustand + ". Motorläuft ist " + this.MotorLaeuft);
    }
}


// Auch Zugriffsmodiefier können gesetzt werden
// dabei kann nur einer der beiden einen Modifier erhalten,
// der Andere erhlt automatisch den der Methode