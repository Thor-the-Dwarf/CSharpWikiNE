
Console.WriteLine("for Schleife");
Console.WriteLine("Zählschleife");
Console.WriteLine("Kopfgesteuert");
Console.WriteLine("for (Initialisierung (start); Bedingung; Iteration (Veränderung))");

for (int i = 0; i < 10; i += 2)
{
    Console.WriteLine("der Wert von i ist: " + i);  // Hello Hello Hello Hello Hello 
}

Console.WriteLine("enhanced for");
Console.WriteLine("foreach Schleife");
Console.WriteLine("Zählschleife");
Console.WriteLine("Läuft durch die gesamte Liste");

// Erstellen eines Arrays von Zahlen
int[] zahlen = { 1, 2, 3, 4, 5 };

// Durchlaufen des Arrays mit einer foreach-Schleife
foreach (int zahl in zahlen)
{
    Console.WriteLine("Aktuelle Zahl: " + zahl);
}

// Erstellen eines Arrays von Strings
string[] namen = { "Peter", "Paul", "Mary" };

// Durchlaufen des Arrays mit einer foreach-Schleife
Console.WriteLine("Namen:");
foreach (string name in namen)
{
    Console.WriteLine(name);
}

// Durchlaufen des Arrays mit einer for-Schleife
for (int i = 0; i < namen.Length; i++)
{
    Console.WriteLine("der wert von namen[" + i +"] ist: " + namen[i]);
}
