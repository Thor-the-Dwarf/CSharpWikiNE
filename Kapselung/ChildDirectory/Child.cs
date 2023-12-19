using Kapselung.ParentDirektory;

namespace Kapselung.ChildDirectory
{
    // Console.WriteLine(child._privateProtected);
    public class Child : Parent
    {
        public void zeigeKapsellung()
        {
            Console.WriteLine("Child:");
            Console.WriteLine(this._public);
            Console.WriteLine(this._protected);
            // Console.WriteLine(this._private); // komme nicht rann
            // Console.WriteLine(this._alsoPrivate);   // komme nicht rann
            Console.WriteLine(this._protectedInternal);
            Console.WriteLine(this._privateProtected);
        }

        public static void Main(string[] args)
        {
            Child child = new Child();
            child.zeigeKapsellung();

            Parent parent = new Parent();
            parent.zeigeKapsellung();
        }
    }
}

