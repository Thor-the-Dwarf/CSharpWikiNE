using System.Diagnostics;

namespace _020_AutoProperties;

public class Auto
{
    public int AnzahlSitzplaetze { get; set; }

    public Auto()
    {
        this.AnzahlSitzplaetze = 3;
    }
    
}

// Auto-Properties
// automatisch implementierte Eigenschaften
// der Compiler erstellt automatisch ein privates,
// anonymes Backing-Feld im Hintergrund