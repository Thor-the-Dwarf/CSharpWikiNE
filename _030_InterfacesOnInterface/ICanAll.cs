namespace _030_InterfacesOnInterface;

public interface ICanAll : ICanWalk, ICanFly, ICanSwim
{
    void Think();
}

public interface ICanWalk
{
    void Walk();
}

public interface ICanFly
{
    void Fly();
}
public interface ICanSwim
{
    void Swim();
}

public class Albatross : ICanAll
{
    public void Walk()
    {
        // todo: Algorythmus der macht das es läft wie ein Albatross 
        Console.WriteLine("Läuft wie ein Albatross");
    }

    public void Fly()
    {
        // todo: Algorythmus der macht das es fliegt wie ein Albatross 
        Console.WriteLine("Fliegt wie ein Albatross");    
    }

    public void Swim()
    {
        // todo: Algorythmus der macht das es schwimmt wie ein Albatross 
        Console.WriteLine("Schwimmt wie ein Albatross");
    }

    public void Think()
    {
        // todo: Algorythmus der macht das es denkt wie ein Albatross 
        Console.WriteLine("Denkt wie ein Albatross");
    }
}