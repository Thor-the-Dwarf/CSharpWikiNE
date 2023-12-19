
Console.WriteLine("Random ist ein Objekttyp das heißt das erzeugte Objekt hat Methoden");
// so erzeugt man ein Objekt
Random rnd = new Random();

Console.WriteLine("Objekt falsch nutzen:");
Console.WriteLine(rnd);  // Gibt den Typnamen des Random-Objekts aus, z.B. "System.Random"

Console.WriteLine("Objekt richtig nutzen:");

// 1. Rückgabewert der Objektmethode dierekt ausgeben
Console.WriteLine(rnd.Next(6));  // 0 - 5

// 2. Rückgabewert der Objektmethode auffangen
int zahl1 = rnd.Next(6);
int zahl2 = rnd.Next(6);
Console.WriteLine(zahl1 + " " + zahl2);

Console.WriteLine("wenn man sicher ist das man das Objekt nur einmal nutzen wird:");

// 3 Objekt erzuegen um den Rückgabewert der Methode des Objektes direkt nutzen
Console.WriteLine(new Random().Next(6));

// 4. Objekt erzuegen um den Rückgabewert der Methode des Objektes auffangen
int zahl4 = new Random().Next(6);
Console.WriteLine(zahl4);


Console.WriteLine("Einige Methoden des Random Objekts");

Console.WriteLine(".Next()");
Console.WriteLine("generiert eine positive Zufallszahl bis zum Höchstwert von Integer 2.147.483.647");
Console.WriteLine(rnd.Next());                      // 0 - 2.147.483.647

Console.WriteLine(".Next(maxValue)");
Console.WriteLine("generiert eine positive Zufallszahl bis exclusive des 'maxValue'");
Console.WriteLine(rnd.Next(6));             // 0 - 5

Console.WriteLine(".NextDouble()");
Console.WriteLine("generiert eine Zufallszahl zwischen 0 und 1");
Console.WriteLine(rnd.NextDouble());                // 0 - 0.99999999



// Next(maxValue)
// Gibt eine Zufallszahl zwischen 0 und maxValue (exklusiv) zurück
Console.WriteLine(rnd.Next(6) + 1);  // 1 - 6

// Objekte richtig nutzen

// NextDouble()
Console.WriteLine(rnd.NextDouble());                // 0 - 0.99999999
Console.WriteLine(rnd.NextDouble() * 6);            // 0 - 5.99999999
