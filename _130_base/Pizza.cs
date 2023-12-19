namespace _110_base;

public class Pizza {

    public string typ;
    public int durchmesser;
    
    public Pizza() {
        this.typ = "Margherita";
        this.durchmesser = 28;
        Console.WriteLine(this.typ + " " + this.durchmesser + " wurde gebacken!");
    }

    public Pizza(String typ) {
        this.typ = typ;   // Dieses this ist Pflicht!!!
        this.durchmesser = 28;
        Console.WriteLine(this.typ + " " + this.durchmesser + " wurde gebacken!");
        Console.WriteLine("Child");
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