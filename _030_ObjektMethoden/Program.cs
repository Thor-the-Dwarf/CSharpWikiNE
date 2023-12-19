

Pizza pizza = new Pizza();
Console.WriteLine(pizza.typ);
Console.WriteLine(pizza.durchmesser);
pizza.beschreibeDich();

public class Pizza
{
    // Objekt-Methode
    // Gehören dem Objekt
    // Fähigkeiten
    public string typ = "Margherita";
    public int durchmesser = 28;

    public void beschreibeDich() {
        Console.WriteLine("Ich bin eine Pizza!");
    }
}