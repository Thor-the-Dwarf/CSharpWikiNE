namespace Aufgabe_910_OnlineShop;

public class Main
{
    /*
 * Online-Shop
 *
 * In dieser Übung erstellen wir Programmbestandteile,
 * die verwendet werden können, um einen Online-Shop zu betreiben.
 *
 *
 * Teil 1: Lager
 *
 * Erstellen Sie die Klasse Lager mit den folgenden Methoden:
 *
 * public void FuegeProduktHinzu(string produkt, int preis, int bestand)
 * Fügt ein Produkt dem Lager hinzu mit dem als Parameter gegebenen Preis und Bestand.
 *
 * public int Preis(string produkt)
 * Gibt den Preis des Produkts zurück, das als Parameter übergeben wurde.
 * Wenn das Produkt nicht zum Lager hinzugefügt wurde, muss die Methode -99 zurückgeben.
 *
 * Die Produkte im Lager (und im nächsten Teil deren Bestand)
 * müssen in einer Variablen des Typs Dictionary<string, int> gespeichert werden!
 */
// Lager lager = new Lager();
// lager.FuegeProduktHinzu("Milch", 3, 10);
// lager.FuegeProduktHinzu("Kaffee", 5, 7);
//
// Console.WriteLine("Preise:");
// Console.WriteLine("Milch: " + lager.Preis("Milch"));
// Console.WriteLine("Kaffee: " + lager.Preis("Kaffee"));
// Console.WriteLine("Zucker: " + lager.Preis("Zucker"));
/*
 * Beispiel-Ausgabe:
 * Preise:
 * Milch: 3
 * Kaffee: 5
 * Zucker: -99
 *
 *
 * Teil 2: Bestandsmenge der Produkte
 *
 * Speichern Sie die Bestandsmenge der Produkte in einer Variable vom Typ Dictionary<string, int>,
 * auf die gleiche Weise, wie die Preise gespeichert wurden. Ergänzen Sie das Lager mit den folgenden Methoden:
 *
 * public int Bestand(string produkt)
 * Gibt den aktuellen verbleibenden Bestand des Produkts im Lager zurück.
 * Wenn das Produkt nicht zum Lager hinzugefügt wurde, muss die Methode 0 zurückgeben.
 *
 * public bool Nehme(string produkt)
 * Reduziert den verbleibenden Bestand des als Parameter erhaltenen Produkts um eins
 * und gibt true zurück, wenn noch Bestand vorhanden war.
 * Wenn das Produkt im Lager nicht verfügbar war, gibt die Methode false zurück.
 * Der Bestand eines Produkts darf nicht unter null fallen.
 *
 * Ein Beispiel für die Verwendung des Lagers:
 */
// Lager lager = new Lager();
// lager.FuegeProduktHinzu("Kaffee", 5, 1);
//
// Console.WriteLine("Bestand:");
// Console.WriteLine("Kaffee:  " + lager.Bestand("Kaffee"));
// Console.WriteLine("Zucker: " + lager.Bestand("Zucker"));
//
// Console.WriteLine("Kaffee nehmen " + lager.Nehme("Kaffee"));
// Console.WriteLine("Kaffee nehmen " + lager.Nehme("Kaffee"));
// Console.WriteLine("Zucker nehmen " + lager.Nehme("Zucker"));
//
// Console.WriteLine("Bestand:");
// Console.WriteLine("Kaffee:  " + lager.Bestand("Kaffee"));
// Console.WriteLine("Zucker: " + lager.Bestand("Zucker"));
/*
 * Beispiel-Ausgabe:
 * Bestand:
 * Kaffee:  1
 * Zucker: 0
 * Kaffee nehmen true
 * Kaffee nehmen false
 * Zucker nehmen false
 * Bestand:
 * Kaffee:  0
 * Zucker: 0
 *
 *
 * Teil 3: Auflistung der Produkte
 *
 * Fügen wir dem Lager noch eine weitere Methode hinzu:
 *
 * public HashSet<string> Produkte() gibt die Namen der Produkte im Lager als HashSet zurück.
 *
 * Diese Methode ist einfach mit einem Dictionary zu implementieren.
 * Sie können die Produkte im Lager entweder aus dem Dictionary, das die Preise speichert,
 * oder dem, das den aktuellen Bestand speichert, mithilfe der Methode Keys erhalten.
 *
 * Ein Beispiel für die Verwendung:
 */
// Lager lager = new Lager();
// lager.FuegeProduktHinzu("Milch", 3, 10);
// lager.FuegeProduktHinzu("Kaffee", 5, 6);
// lager.FuegeProduktHinzu("Buttermilch", 2, 20);
// lager.FuegeProduktHinzu("Joghurt", 2, 
}