namespace _010_EinfachesInterface;

// Interface ICanWalk
public interface ICanWalk
{
    // Methode, die das Gehen repräsentiert
    void Walk();
}

// Klasse Humanoid, die das Interface ICanWalk implementiert
public class Humanoid : ICanWalk
{
    public void Walk()
    {
        // Implementierung der Walk-Methode für Humanoid
        Console.WriteLine("Läuft wie ein Humanoid");
    }
}