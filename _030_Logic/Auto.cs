namespace _030_Logic;

public class Auto
{

    private int _hoechstgeschwindigkeit;
    
    public int Hoechstgeschwindigkeit
    {
        get
        {
            if (this._hoechstgeschwindigkeit > 120)
                return this._hoechstgeschwindigkeit;
            else
                return 100;
        }
        set
        {
            int limit = 450;
            
            if (value < 0) 
            {
                Console.WriteLine("Negativer Wert ist bei Höchstgeschwindigkeit nicht erlaubt");
            }
            else if( value > limit)
            {
                this._hoechstgeschwindigkeit = limit;
                Console.WriteLine
                (
                    "damit bekommst du keine Zulassung. Neue Höchstgeschwindigkeit ist " + 
                    this._hoechstgeschwindigkeit + " km/h"
                );
            }
            else
            {
                this._hoechstgeschwindigkeit = value;
            }
        }
    }
}