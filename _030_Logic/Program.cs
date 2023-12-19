using System;
using _030_Logic;

class Program
{
    static void Main()
    {
        Auto meinAuto = new Auto();

        Console.WriteLine("Setze Höchstgeschwindigkeit auf 150 km/h.");
        meinAuto.Hoechstgeschwindigkeit = 150;
        Console.WriteLine("Aktuelle Höchstgeschwindigkeit: " + meinAuto.Hoechstgeschwindigkeit + " km/h");

        Console.WriteLine("\nSetze Höchstgeschwindigkeit auf 500 km/h.");
        meinAuto.Hoechstgeschwindigkeit = 500;
        Console.WriteLine("Aktuelle Höchstgeschwindigkeit: " + meinAuto.Hoechstgeschwindigkeit + " km/h");
        
        Console.WriteLine("\nSetze Höchstgeschwindigkeit auf -10 km/h.");
        meinAuto.Hoechstgeschwindigkeit = -10;
        Console.WriteLine("Aktuelle Höchstgeschwindigkeit: " + meinAuto.Hoechstgeschwindigkeit + " km/h");
    }
}