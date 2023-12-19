
using _030_InterfacesOnInterface;

namespace _170_Polymorphie;

class Programm
{
    static void Main()
    {
        // Polymorphie dient DRY
        // Don´t Repeat Yourself
        Androide androide1 = new Androide();
        Humanoid humanoid1 = new Humanoid();
        ArchAngel archAngel1 = new ArchAngel();
        Console.WriteLine(androide1);
        Console.WriteLine(humanoid1);
        Console.WriteLine(archAngel1);
        
        // Casting mit eigenen Datentypen
        Androide humanoid2 = new Humanoid();
        Androide archAngel2 = new ArchAngel();
        // ArchAngel androide2 = new Androide(); // Compiler Error: Der Typ "Androide" kann nicht implizit in "ArchAngel" konvertiert werden.
        // ArchAngel androide3 = (ArchAngel)new Androide(); // Runtime Error: System.InvalidCastException
        

        // Polymorphie dient der Skallierbarkeit, der Strukturierbarkeit und der Wiederverwendbarkeit
        Roboter[] schwarm1 =
            { androide1, humanoid1, humanoid2, archAngel1, archAngel2, new Androide() };

        foreach (Roboter roboter in schwarm1)
        {
            roboter.Activate();
        }

        ICanWalk[] schwarm2 = 
            { androide1, humanoid1, humanoid2, archAngel1, archAngel2, (Androide)schwarm1[schwarm1.Length -1] };

        foreach (ICanWalk walker in schwarm2)
        {
            walker.Walk();
        }

        Object[] objekte = { "String", new Random(), new ArchAngel(), 123456, true, 357.951, 'A' };
        foreach (object o in objekte)
        {
            string String = o.ToString();
            Console.WriteLine(String);
        }



    }
}