
Console.WriteLine(Pizza.counter);
Pizza pizza = new Pizza();
Console.WriteLine(Pizza.counter);
Pizza pizza1 = new Pizza();
Console.WriteLine(Pizza.counter);
Pizza pizza2 = new Pizza();
Pizza.staticMethod();
// Console.WriteLine(pizza2.counter);   // Objekte/Instanzen können nicht auf statisches zugreifen
// pizza1.statichMethod();              // Objekte/Instanzen können nicht auf statisches zugreifen


public class Pizza
{

    // Statische Attribute - Klassen Attribute - Klassen Variablen
    // Statisches gehört der Klasse, nicht den Objekten
    // Nichtstatisches göhren den Objekten/Instanzen, nicht der Klasse
    
    public static int counter = 0;
    public string typ;
    public int durchmesser;
    
    public Pizza() {
        this.typ = "Margherita";
        this.durchmesser = 28;
        Pizza.counter++;
    }

    public static void staticMethod()
    {
        Console.WriteLine(counter);
        // Console.WriteLine(typ);          // dieses Attribut gehört den Objekten
        // Console.WriteLine(durchmesser);  // dieses Attribut gehört den Instanzen
    }
}