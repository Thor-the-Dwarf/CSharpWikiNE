
namespace Kapselung.ParentDirektory
{
    public class Parent()
    {
        public string _public = "public";
        protected string _protected = "protected";
        private string _private = "private";
        string _alsoPrivate = "alsoPrivate";
        protected internal string _protectedInternal = "protectedInternal";
        private protected string _privateProtected = "privateProtected";

        public void zeigeKapsellung()
        {
            Console.WriteLine("Parent:");
            Console.WriteLine(this._public);
            Console.WriteLine(this._protected);
            Console.WriteLine(this._private);
            Console.WriteLine(this._alsoPrivate);
            Console.WriteLine(this._protectedInternal);
            Console.WriteLine(this._privateProtected);
        }

        public static void Main(string[] args)
        {
            Parent parent = new Parent();
            parent.zeigeKapsellung();
            Console.WriteLine("Parent - ");
            Console.WriteLine(parent._public);
            Console.WriteLine(parent._protected);
            Console.WriteLine(parent._private);
            Console.WriteLine(parent._alsoPrivate);
            Console.WriteLine(parent._protectedInternal);
            Console.WriteLine(parent._privateProtected);        

            Child child = new Child();
            parent.zeigeKapsellung();
            Console.WriteLine("Parent - ");
            Console.WriteLine(child._public);
            Console.WriteLine(child._protected);
            Console.WriteLine(child._private);
            Console.WriteLine(child._alsoPrivate);
            Console.WriteLine(child._protectedInternal);
        }
    }
}