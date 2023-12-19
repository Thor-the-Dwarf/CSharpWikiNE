namespace Aufgabe_780_Herden;

public class Main
{
    /*
 * Herden
 *
 * In dieser Übung werden wir Organismen und Herden von Organismen erstellen, die sich bewegen können.
 * Um die Positionen der Organismen darzustellen, verwenden wir ein zweidimensionales Koordinatensystem.
 * Jede Position besteht aus zwei Zahlen: den x- und y-Koordinaten.
 * Die x-Koordinate zeigt, wie weit eine Position horizontal vom Ursprung entfernt ist
 * (d.h. Punkt Null, wo x = 0, y = 0).
 * Die y-Koordinate zeigt den vertikalen Abstand vom Ursprung.
 * Wenn Sie mit der Verwendung eines Koordinatensystems nicht vertraut sind,
 * können Sie die Grundlagen auf Wikipedia nachlesen.
 * https://de.wikipedia.org/wiki/Kartesisches_Koordinatensystem
 *
 * Die Übungsbasis umfasst das Interface IMovable,
 * das etwas darstellt, das von einer Position zu einer anderen bewegt werden kann.
 * Das Interface beinhaltet die Methode void Bewege(int dx, int dy).
 * Der Parameter dx gibt an, wie viel sich das Objekt auf der x-Achse bewegt,
 * und dy gibt die Entfernung auf der y-Achse an.
 *
 * Diese Übung beinhaltet die Implementierung der Klassen Organismus und Herde,
 * die beide beweglich sind.
 *
 *
 * Teil 1: Implementierung der Klasse Organismus
 *
 * Erstellen Sie eine Klasse namens Organismus, die das Interface IMovable implementiert.
 * Ein Organismus sollte seine eigene Position kennen (als x-, y-Koordinaten).
 * Die API für die Klasse Organismus soll wie folgt sein:
 *
 * public Organismus(int x, int y)
 * Der Klassenkonstruktor, der die x- und y-Koordinaten
 * der Anfangsposition als Parameter erhält.
 *
 * public override string ToString()
 * Erstellt und gibt eine String-Darstellung des Organismus zurück.
 * Diese Darstellung sollte folgendermaßen aussehen: "x: 3; y: 6".
 * Beachten Sie, dass ein Semikolon verwendet wird, um die Koordinaten zu trennen.
 *
 * public void Bewege(int dx, int dy)
 * Bewegt das Objekt um die Werte, die es als Parameter erhält.
 * Die Variable dx enthält die Änderung der Koordinate x,
 * und die Variable dy enthält die Änderung der Koordinate y.
 * Zum Beispiel, wenn der Wert von dx 5 ist,
 * sollte der Wert der Objektvariablen x um fünf erhöht werden.
 *
 * Verwenden Sie den folgenden Code-Snippet, um die Klasse Organismus zu testen.
 */
// Organismus organismus = new Organismus(20, 30);
// Console.WriteLine(organismus);
// organismus.Bewege(-10, 5);
// Console.WriteLine(organismus);
// organismus.Bewege(50, 20);
// Console.WriteLine(organismus);
/*
 * Beispiel-Ausgabe:
 * x: 20; y: 30
 * x: 10; y: 35
 * x: 60; y: 55
 *
 *
 * Teil 2: Implementierung der Herde
 *
 * Erstellen Sie eine Klasse namens Herde, die das Interface IMovable implementiert.
 * Eine Herde besteht aus mehreren Objekten, die das IMovable-Interface implementieren.
 * Sie müssen in einer Liste oder einer ähnlichen Datenstruktur gespeichert werden.
 *
 * Die Herde-Klasse muss folgende API haben:
 *
 * public override string ToString()
 * Gibt eine String-Darstellung der Positionen der Mitglieder der Herde zurück,
 * jedes auf seiner eigenen Zeile.
 *
 * public void FuegeZuHerdeHinzu(IMovable beweglich)
 * Fügt ein Objekt, das das IMovable-Interface implementiert, zur Herde hinzu.
 *
 * public void Bewege(int dx, int dy)
 * Bewegt die Herde um den Betrag, der durch die Parameter angegeben wird.
 * Beachten Sie, dass hier jedes Mitglied der Herde bewegt werden muss.
 *
 * Testen Sie Ihr Programm mit dem folgenden Beispielcode:
 */
// Herde herde = new Herde();
// herde.FuegeZuHerdeHinzu(new Organismus(57, 66));
// herde.FuegeZuHerdeHinzu(new Organismus(73,

}