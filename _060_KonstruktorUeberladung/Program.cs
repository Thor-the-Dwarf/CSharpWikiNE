Pizza pizza = new Pizza();
Pizza pizza1 = new Pizza("Salami");
Pizza pizza2 = new Pizza(35);
Pizza pizza3 = new Pizza("Speziale", 20);

public class Pizza {


    public string typ;
    public int durchmesser;
    
    
    // sobald man einen Konstruktor schreibt verschwindet dieser Parameterlose Konstruktor
    // dieser wird vom Compiler automatisch hineingeschrieben wenn keiner vorhanden ist
    // man nennt ihn: StandartKonstruktor oder DefaultKonstruktor
    
    public Pizza() {
        this.typ = "Margherita";
        this.durchmesser = 28;
        Console.WriteLine(this.typ + " " + this.durchmesser + " wurde gebacken!");
    }

    public Pizza(String typ) {
        this.typ = typ;   // Dieses this ist Pflicht!!!
        this.durchmesser = 28;
        Console.WriteLine(this.typ + " " + this.durchmesser + " wurde gebacken!");
    }

    public Pizza(int durchmesser) {
        this.typ = "Margherita";
        this.durchmesser = durchmesser;   // Dieses this ist Pflicht!!!
        Console.WriteLine(this.typ + " " + this.durchmesser + " wurde gebacken!");
    }

    public Pizza(String typ, int durchmesser) {
        this.typ = typ;                   // Dieses this ist Pflicht!!!
        this.durchmesser = durchmesser;   // Dieses this ist Pflicht!!!
        Console.WriteLine(this.typ + " " + this.durchmesser + " wurde gebacken!");
    }

    public void beschreibeDich() {
        Console.WriteLine("Ich bin eine Pizza: ");
        Console.WriteLine(this.typ + ": " + durchmesser + " cm");
    }

}