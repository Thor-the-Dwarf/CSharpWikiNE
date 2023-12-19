namespace _110_base;

public class DoppeldeckerPizza : Pizza
{
    public DoppeldeckerPizza() : base()
    {
    }

    public DoppeldeckerPizza(String typ) {
        this.typ = typ;   // Dieses this ist Pflicht!!!
        this.durchmesser = 28;
        Console.WriteLine(this.typ + " " + this.durchmesser + " wurde gebacken!");
        Console.WriteLine("Child");
    }

    public DoppeldeckerPizza(int durchmesser) {
        this.typ = "Margherita";
        this.durchmesser = durchmesser;   // Dieses this ist Pflicht!!!
        Console.WriteLine(this.typ + " " + this.durchmesser + " wurde gebacken!");
    }

    public DoppeldeckerPizza(String typ, int durchmesser) {
        this.typ = typ;                   // Dieses this ist Pflicht!!!
        this.durchmesser = durchmesser;   // Dieses this ist Pflicht!!!
        Console.WriteLine(this.typ + " " + this.durchmesser + " wurde gebacken!");
    }
}