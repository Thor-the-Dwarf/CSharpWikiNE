using ChildProject;
using ParentProject;

namespace ChildProject
{
    public class Child : Parent
    {
        new
            public void ZeigeKapselung()
        {
            Console.Write("Child:");
            Console.Write(this.Public + ", ");
            // Console.Write(this.Internal + ", ");
            Console.Write(this.Protected + ", ");
            // Console.Write(this.Private + ", ");
            // Console.Write(this.AlsoPrivate);
            Console.WriteLine();
        }
    }

    public class Programm
    {

        public static void Main(string[] args)
        {

            Child child = new Child();
            child.ZeigeKapselung();
            Console.WriteLine(child.Public);
            // Console.WriteLine(child.Internal); // nicht erreichbar
            // Console.WriteLine(child.Protected); // nicht erreichbar
            // Console.WriteLine(child.Private); // nicht erreichbar
            // Console.WriteLine(child.AlsoPrivate); // nicht erreichbar
            
            
            Parent parent = new Parent();
            parent.ZeigeKapselung();
            Console.WriteLine(parent.Public);
            // Console.WriteLine(parent.Internal);
            // Console.WriteLine(parent.Protected); // nicht erreichbar
            // Console.WriteLine(parent.Private); // nicht erreichbar
            // Console.WriteLine(parent.AlsoPrivate); // nicht erreichbar
        }

    }
}


