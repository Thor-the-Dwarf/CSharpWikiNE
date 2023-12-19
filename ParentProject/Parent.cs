namespace ParentProject;

public class Parent
{
    public string Public = "public";
    internal string Internal = "internal";
    protected string Protected = "protected";
    private string Private = "private";
    string AlsoPrivate = "alsoPrivate";

    public void ZeigeKapselung()
    {
        Console.Write("Parent:");
        Console.Write(this.Public + ", ");
        Console.Write(this.Internal + ", ");
        Console.Write(this.Protected + ", ");
        Console.Write(this.Private + ", ");
        Console.Write(this.AlsoPrivate);
        Console.WriteLine();
    }

    public Parent()
    {
        initialize();
    }

    protected void initialize()
    {
        // Ein Algorythmus zur vollständigen erstellung des Objektes inklusive Datenbankabrage
    }
    
}

public class Programm
{

    public static void Main(string[] args)
    {

        Parent parent = new Parent();
        parent.ZeigeKapselung();
        Console.WriteLine(parent.Public);
        Console.WriteLine(parent.Internal);
        // Console.WriteLine(parent.Protected); // nicht erreichbar
        // Console.WriteLine(parent.Private); // nicht erreichbar
        // Console.WriteLine(parent.AlsoPrivate); // nicht erreichbar
    }

}