public class OverWrite
{
    public static void Main(string[] args)
    {
        new Fahrzeug().starteMotor();
        new Motorrad().starteMotor();
        
    }
}

class Fahrzeug
{
    // Um Methoden überschreiben zu dürfen muss die Methode "virtual" sein
    internal virtual void starteMotor() {
        Console.WriteLine("Fahrzeug hat den Motor gestartet");
    }
}

class Motorrad : Fahrzeug
{
     
    // Überschreibende Methoden müssen den gleichen Acces-Modifier haben
    // private override void starteMotor()          // falscher Acces-Modifier
    // protected override void starteMotor()        // falscher Acces-Modifier
    internal override void starteMotor() 
    // public override void starteMotor()           // falscher Acces-Modifier
    {
        Console.WriteLine("Motorrad hat den Motor gestartet");
    }
}