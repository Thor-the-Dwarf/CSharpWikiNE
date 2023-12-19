namespace Aufgabe_270_Gehaltsabrechnung;

/*
 * In dieser Aufgabe sind Kommentare die mit "//" beginnen dafür gedacht einkommentiert zu werden
 */

public class Main
{
 /*
 * Sensoren und Temperatur
 *
 *
 * Teil 1: Standardsensor
 *
 * Erstellen Sie eine Klasse namens Standardsensor, die das Interface ISensor implementiert:
 *
 * public interface ISensor {
 *     bool IstAn();    // gibt true zurück, wenn der Sensor an ist
 *     void SetzeAn();  // schaltet den Sensor an
 *     void SetzeAus(); // schaltet den Sensor aus
 *     int Lese();      // gibt den Wert des Sensors zurück, wenn er an ist
 *                      // wenn der Sensor nicht an ist, wirft es eine InvalidOperationException
 * }
 *
 * Ein Standardsensor ist immer an. Die Methoden SetzeAn() und SetzeAus() haben keine Auswirkung.
 * Der Standardsensor muss einen Konstruktor haben, der einen Integer-Parameter annimmt.
 * Der Methodenaufruf Lese() gibt die Zahl zurück, die dem Konstruktor übergeben wurde.
 *
 * Ein Beispiel:
 */
    
// Standardsensor zehn = new Standardsensor(10);
// Standardsensor minusFuenf = new Standardsensor(-5);
//
// Console.WriteLine(zehn.Lese());
// Console.WriteLine(minusFuenf.Lese());
//
// Console.WriteLine(zehn.IstAn());
// zehn.SetzeAus();
// Console.WriteLine(zehn.IstAn());
 
/*
 * Beispiel-Ausgabe:
 * 10
 * -5
 * true
 * true
 *
 *
 * Teil 2: Temperatursensor
 *
 * Erstellen Sie eine Klasse Temperatursensor, die das Interface ISensor implementiert.
 *
 * Anfangs ist ein Temperatursensor ausgeschaltet.
 * Wenn die Methode Lese() aufgerufen wird und der Sensor eingeschaltet ist,
 * wählt der Sensor zufällig eine ganze Zahl im Bereich -30...30 aus und gibt sie zurück.
 * Wenn der Sensor ausgeschaltet ist, wirft die Methode Lese() eine InvalidOperationException.
 *
 * Verwenden Sie die fertige C#-Klasse Random, um die Zufallszahl auszuwählen.
 *
 *
 * Teil 3: Durchschnittssensor
 *
 * Erstellen Sie eine Klasse namens Durchschnittssensor, die das Interface ISensor implementiert.
 *
 * Ein Durchschnittssensor umfasst mehrere Sensoren.
 * Zusätzlich zu den Methoden, die im ISensor-Interface definiert sind,
 * hat der Durchschnittssensor die Methode public void FuegeSensorHinzu(ISensor hinzuzufuegen),
 * die verwendet werden kann, um einen neuen Sensor für den Durchschnittssensor hinzuzufügen.
 *
 * Ein Durchschnittssensor ist eingeschaltet, wenn alle seine Sensoren eingeschaltet sind.
 * Wenn SetzeAn aufgerufen wird, müssen alle Sensoren eingeschaltet werden.
 * Wenn SetzeAus aufgerufen wird, muss mindestens einer der Sensoren ausgeschaltet werden.
 *
 * Die Methode Lese des Durchschnittssensors gibt den Durchschnitt der Lese-Methoden seiner Sensoren zurück
 * (da der Rückgabewert int ist, wird die Zahl bei der Ganzzahldivision abgerundet).
 * Wenn diese Methode aufgerufen wird, während der Durchschnittssensor ausgeschaltet ist,
 * oder wenn keine Sensoren hinzugefügt wurden, sollte die Methode eine InvalidOperationException werfen.
 *
 * Hier folgt ein Beispielprogramm, das die Sensoren verwendet:
 */

// ISensor kumpula = new Temperatursensor();
// kumpula.SetzeAn();
// Console.WriteLine("Temperatur in Kumpula " + kumpula.Lese() + " Grad Celsius");
//
// ISensor kaisaniemi = new Temperatursensor();
// ISensor flughafenHelsinkiVantaa = new Temperatursensor();
//
// Durchschnittssensor helsinkiRegion = new Durchschnittssensor();
// helsinkiRegion.FuegeSensorHinzu(kumpula);
// helsinkiRegion.FuegeSensorHinzu(kaisaniemi);
// helsinkiRegion.FuegeSensorHinzu(flughafenHelsinkiVantaa);
//
// helsinkiRegion.SetzeAn();
// Console.WriteLine("Temperatur in der Region Helsinki " + helsinkiRegion.Lese() + " Grad Celsius");

/*
 *
 * Beispiel-Ausgabe (abhängig davon, welche Temperaturen zufällig zurückgegeben werden):
 * Temperatur in Kumpula 11 Grad Celsius
 * Temperatur in der Region Helsinki 8 Grad Celsius
 *
 *
 * Teil 4: Alle Messwerte
 *
 * Fügen Sie der Klasse Durchschnittssensor die Methode public List<int> Messwerte() hinzu.
 * Die Methode sollte die Ergebnisse aller durchgeführten Messungen, die der Durchschnittssensor durchgeführt hat, als Liste zurückgeben.
 * Hier ist ein Beispiel:
 */

// ISensor kumpula = new Temperatursensor();
// ISensor kaisaniemi = new Temperatursensor();
// ISensor flughafenHelsinkiVantaa = new Temperatursensor();
//
// Durchschnittssensor helsinkiRegion = new Durchschnittssensor();
// helsinkiRegion.FuegeSensorHinzu(kumpula);
// helsinkiRegion.FuegeSensorHinzu(kaisaniemi);
// helsinkiRegion.FuegeSensorHinzu(flughafenHelsinkiVantaa);
//
// helsinkiRegion.SetzeAn();
// Console.WriteLine("Temperatur in der Region Helsinki " + helsinkiRegion.Lese() + " Grad Celsius");
// Console.WriteLine("Temperatur in der Region Helsinki " + helsinkiRegion.Lese() + " Grad Celsius");
// Console.WriteLine("Temperatur in der Region Helsinki " + helsinkiRegion.Lese() + " Grad Celsius");
//
// Console.WriteLine("Messwerte: " + helsinkiRegion.Messwerte());
/*
 *
 * Beispiel-Ausgabe (abhängig davon, welche Temperaturen zufällig zurückgegeben werden):
 * Temperatur in der Region Helsinki -10 Grad Celsius
 * Temperatur in der Region Helsinki -4 Grad Celsius
 * Temperatur in der Region Helsinki 5 Grad Celsius
 *
 * Messwerte: [-10, -4, 5]
 */
}