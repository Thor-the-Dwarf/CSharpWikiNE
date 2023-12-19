using _040_AccesModifier;

class Programm
{
    static void Main()
    {
        Auto meinAuto = new Auto();

        Console.WriteLine("Motor läuft: " + meinAuto.MotorLaeuft);

        // meinAuto.MotorLäuft = true;  // Fehler: Kein Zugriff

        // Console.WriteLine("Wartungszustand: " + meinAuto.Wartungszustand);  // Fehler: Kein Zugriff

        meinAuto.Wartungszustand = "OK"; 
        
        meinAuto.DoService();
    }
}