using _030_InterfacesOnInterface;

namespace _170_Polymorphie;

public abstract class Roboter
{
    public static int counter = 0;
    public int id;
    protected string typ;
    protected string kennung;
    
    
    public Roboter()
    {
        this.id = ++counter;
    }

    public void Activate()
    {
        Console.WriteLine($"{kennung} aktiviert");
    }

    public override string ToString()
    {
        return $"{this.typ}{{ id: {this.id}}}";
    }
}

public class Androide : Roboter, ICanWalk
{
    
    public Androide()
    {
        this.typ = "Androide";
        kennung = this.ToString();
    }

    public void Walk()
    {
        Console.WriteLine($"{kennung} läuft");
    }
}

public class Humanoid : Androide , ICanSwim
{
    public Humanoid()
    {
        this.typ = "Humanoid";
    }
    public void Swim()
    {
        Console.WriteLine($"{kennung} schwimmt");

    }
}

public class ArchAngel : Humanoid, ICanAll
{
    
    public ArchAngel()
    {
        this.typ = "ArchAngel";
    }
    public void Fly()
    {
        Console.WriteLine($"{kennung} fliegt");
    }

    public void Think()
    {
        Console.WriteLine($"{kennung} denkt");
    }
}