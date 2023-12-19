string text = "Hallo Welt! C# ist toll.";

// Länge eines Strings
Console.WriteLine(".Length");
Console.WriteLine("Länge: " + text.Length);

// Teile eines Strings extrahieren
Console.WriteLine("\n.Substring(int startIndex, int length)");
string teilString = text.Substring(0, 5);
Console.WriteLine("Teilstring: " + teilString);

// Strings vergleichen
Console.WriteLine("\n.Equals(string)");
bool sindGleich = text.Equals("Hallo Welt! C# ist toll.");
Console.WriteLine("Sind gleich: " + sindGleich);

// Zeichen in Strings ersetzen
Console.WriteLine("\n.Replace(char oldChar, char newChar)");
string ersetzt = text.Replace('l', 'm');
Console.WriteLine("Ersetzt: " + ersetzt);

// Strings in Klein- oder Großbuchstaben umwandeln
Console.WriteLine("\n.ToLower(), .ToUpper()");
string klein = text.ToLower();
string gross = text.ToUpper();
Console.WriteLine("Klein: " + klein);
Console.WriteLine("Groß: " + gross);

// Prüfen, ob ein String einen Substring enthält
Console.WriteLine("\n.Contains(string)");
bool enthaelt = text.Contains("Welt");
Console.WriteLine("Enthält 'Welt': " + enthaelt);

// String in Array umwandeln
Console.WriteLine("\n.Split(char separator)");
string[] worte = text.Split(' ');
Console.WriteLine("Geteilte Worte:");
foreach (var wort in worte)
{
    Console.WriteLine(wort);
}

// String trimmen
Console.WriteLine("\n.Trim(), .TrimStart(), .TrimEnd()");
string untrimmedText = "   Hallo Welt!   ";
Console.WriteLine("Getrimmt: '" + untrimmedText.Trim() + "'");
Console.WriteLine("Start Getrimmt: '" + untrimmedText.TrimStart() + "'");
Console.WriteLine("Ende Getrimmt: '" + untrimmedText.TrimEnd() + "'");