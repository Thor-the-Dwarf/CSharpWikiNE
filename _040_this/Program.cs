
Pizza pizza = new Pizza();
Console.WriteLine(pizza.typ);
Console.WriteLine(pizza.durchmesser);
pizza.beschreibeDich();

public class Pizza {

    // this
    // Schlüsselwort - keyword
    // Repräsentiert das Objekt
    // Wenn es keine gleichnamige, lokale Variable gibt,
    // kann das this weggelassen werden.

    public String typ = "Margherita";
    public int durchmesser = 28;

    public void beschreibeDich() {
        this.typ = "Heiss";
        Console.WriteLine("Ich bin eine Pizza: ");
        // Console.WriteLine(this.typ + ": " + this.durchmesser + " cm");
        // Console.WriteLine(typ + ": " + durchmesser + " cm");  // Heiss
        Console.WriteLine(this.typ + ": " + durchmesser + " cm");
    }

}