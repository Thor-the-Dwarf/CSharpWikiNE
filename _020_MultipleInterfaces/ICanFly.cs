namespace _020_MultipleInterfaces;

public interface ICanWalk
{
    void Walk();
}

public interface ICanFly
{
    void Fly();
}

public class Angel : ICanWalk, ICanFly
{
    public void Walk()
    {
        Console.WriteLine("Der Engel geht.");
    }

    public void Fly()
    {
        Console.WriteLine("Der Engel fliegt.");
    }
}