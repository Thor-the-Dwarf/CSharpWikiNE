using _010_GetterSetter;

class Program
{
    static void Main(string[] args)
    {
        Auto meinAuto = new Auto();

        // Verwendung des Setters für _farbe
        meinAuto.SetFarbe("Blau");
        
        // Verwendung des Getters für _farbe
        Console.WriteLine("Farbe des Autos: " + meinAuto.GetFarbe());

        // Verwendung des Setters für _baujahr
        meinAuto.Baujahr = 2020;
        
        // Verwendung des Getters für _baujahr
        Console.WriteLine("Baujahr des Autos: " + meinAuto.Baujahr);

        // Verwendung des Setters für _hasDach
        meinAuto.HasDach = true;
        
        // Verwendung des Getters für _hasDach
        Console.WriteLine("Hat das Auto ein Dach? " + meinAuto.HasDach);

        // Verwendung des Setters für _typ
        meinAuto.Typ = "SUV";
        
        // Verwendung des Getters für _typ
        Console.WriteLine("Typ des Autos: " + meinAuto.Typ);
    }
}