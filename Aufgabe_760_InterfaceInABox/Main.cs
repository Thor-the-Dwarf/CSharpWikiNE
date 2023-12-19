namespace Aufgabe_760_InterfaceInABox;

/*
 * In dieser Aufgabe sind Kommentare die mit "//" beginnen dafür gedacht einkommentiert zu werden
 */


public class Main
{
/*
 *     Interface in einer Box

Teil 1: Packbare Objekte

Umziehen erfordert, alle Ihre Habseligkeiten in Kisten zu packen.
Lassen Sie uns das mit einem Programm nachahmen.
Das Programm wird Kisten und Gegenstände haben, die in diese Kisten gepackt werden sollen.
Alle Gegenstände müssen das folgende Interface implementieren:
 */

// public interface IPackbar {
//     double Gewicht();
// }

/*
Fügen Sie das Interface Ihrem Programm hinzu.
Erstellen Sie Klassen Buch und CD, die das Interface implementieren.
Buch hat einen Konstruktor, der den Autor (string), den Namen des Buches (string)
und das Gewicht des Buches (double) als Parameter erhält.
CD hat einen Konstruktor, der den Künstler (string),
den Namen der CD (string) und das Erscheinungsjahr (int) erhält.
Das Gewicht aller CDs beträgt 0,1 kg.

Denken Sie daran, das Interface IPackbar in beiden Klassen zu implementieren.
Die Klassen müssen folgendermaßen funktionieren:
 */

// public static void Main(string[] args) {
//     Buch buch1 = new Buch("Fjodor Dostojewski", "Schuld und Sühne", 2);
//     Buch buch2 = new Buch("Robert Martin", "Clean Code", 1);
//     Buch buch3 = new Buch("Kent Beck", "Testgetriebene Entwicklung", 0.5);
//
//     CD cd1 = new CD("Pink Floyd", "The Dark Side of the Moon", 1973);
//     CD cd2 = new CD("Wigwam", "Nuclear Nightclub", 1975);
//     CD cd3 = new CD("Rendezvous Park", "Closer to Being Here", 2012);
//
//     Console.WriteLine(buch1);
//     Console.WriteLine(buch2);
//     Console.WriteLine(buch3);
//     Console.WriteLine(cd1);
//     Console.WriteLine(cd2);
//     Console.WriteLine(cd3);
// }

/*
 * Beispiel Ausgabe:

Fjodor Dostojewski: Schuld und Sühne
Robert Martin: Clean Code
Kent Beck: Testgetriebene Entwicklung
Pink Floyd: The Dark Side of the Moon (1973)
Wigwam: Nuclear Nightclub (1975)
Rendezvous Park: Closer to Being Here (2012)

NB: Das Gewicht wird nicht gedruckt

Teil 2: Kiste

Erstellen Sie eine Klasse namens Kiste.
Gegenstände, die das IPackbar Interface implementieren, können in eine Kiste gepackt werden.
Der Konstruktor der Kiste nimmt die maximale Kapazität der Kiste in Kilogramm als Parameter.
Das kombinierte Gewicht aller Gegenstände in einer Kiste darf nicht mehr als die maximale Kapazität der Kiste betragen.

Unten ist ein Beispiel für die Verwendung einer Kiste:
 */


// public static void Main(string[] args) {
//     Kiste kiste = new Kiste(10);
//
//     kiste.Hinzufuegen(new Buch("Fjodor Dostojewski", "Schuld und Sühne", 2));
//     kiste.Hinzufuegen(new Buch("Robert Martin", "Clean Code", 1));
//     kiste.Hinzufuegen(new Buch("Kent Beck", "Testgetriebene Entwicklung", 0.7));
//
//     kiste.Hinzufuegen(new CD("Pink Floyd", "The Dark Side of the Moon", 1973));
//     kiste.Hinzufuegen(new CD("Wigwam", "Nuclear Nightclub", 1975));
//     kiste.Hinzufuegen(new CD("Rendezvous Park", "Closer to Being Here", 2012));
//
//     Console.WriteLine(kiste);
// }

/*
 * Beispiel Ausgabe:

Kiste: 6 Gegenstände, Gesamtgewicht 4,0 kg

Teil 3: Kistengewicht

Wenn Sie eine Klassenvariable double gewicht in der Kiste-Klasse erstellt haben,
ersetzen Sie sie durch eine Methode, die das Gewicht der Kiste berechnet:
 */

// public class Kiste {
//     //...
//
//     public double Gewicht() {
//         double gewicht = 0;
//         // Berechnen Sie das Gesamtgewicht der Gegenstände in der Kiste
//         return gewicht;
//     }
// }

/*
Wenn Sie das Gewicht der Kiste benötigen,
zum Beispiel beim Hinzufügen eines neuen
 */

}