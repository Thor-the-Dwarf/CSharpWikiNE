namespace OuterNamespace
{
    // Eine Klasse im äußeren Namespace
    class Class
    {
        public void Display()
        {
            System.Console.WriteLine("OuterClass im OuterNamespace.");
        }
    }

    // Verschachtelter Namespace innerhalb von OuterNamespace
    namespace InnerNamespace
    {
        // Eine Klasse im inneren Namespace
        class Class
        {
            public void Display()
            {
                System.Console.WriteLine("InnerClass im InnerNamespace.");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        OuterNamespace.Class outer = new OuterNamespace.Class();
        outer.Display();

        OuterNamespace.InnerNamespace.Class inner = new OuterNamespace.InnerNamespace.Class();
        inner.Display();
    }
}