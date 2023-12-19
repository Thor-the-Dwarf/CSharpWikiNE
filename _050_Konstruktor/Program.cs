Pizza pizza = new Pizza();
Console.WriteLine(pizza.typ);
Console.WriteLine(pizza.durchmesser);
pizza.beschreibeDich();

public class Pizza {

    // Konstruktor
    // Methode mit dem Namen der Klasse
    // Darf keinen Rückgabewert haben
    // Wenn es keinen Konstruktor gibt,
    // wird vom Compiler ein leerer Default-Konstruktor eingebaut.

    // Standard-Werte besser im Konstruktor festlegen

    // Die Deklaration von Objekt-Attributen kann nur hier stattfinden.

    public string typ;
    public int durchmesser;
    
    public Pizza() {
        // String typ = "Heiss";
        this.typ = "Margherita";
        this.durchmesser = 28;
        Console.WriteLine("Es wurde eine Pizza gebacken!");
    }

    public void beschreibeDich() {
        Console.WriteLine("Ich bin eine Pizza: ");
        Console.WriteLine(this.typ + ": " + durchmesser + " cm");
    }

}