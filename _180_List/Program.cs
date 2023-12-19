using System.Collections.Generic;

Console.WriteLine("List");

// List erstellen
List<int> zahlen = new List<int>();
List<string> namen = new List<string>();

// .Add()
zahlen.Add(1);
zahlen.Add(2);
zahlen.Add(3);
gibZahlenAus("Add()", zahlen);

namen.Add("Peter");
namen.Add("Paul");
namen.Add("Marie");
gibNamenAus("Add()", namen);


// Zugriff
int ersteZahl = zahlen[0];  // 1
string ersterName = namen[0];  // Peter
Console.WriteLine("Einzelne Elemente der Liste");
Console.WriteLine(zahlen[0]);
Console.WriteLine(namen[0]);


// .Remove(value) bei List<Zahl>
zahlen.Remove(1);  // Entfernt die Zahl 1
gibZahlenAus("Remove()", zahlen);

// .RemoveAt(int index)
namen.RemoveAt(1);  // Entfernt "Paul"
gibNamenAus("RemoveAt()", namen);

// .Insert(int index, T item)
zahlen.Insert(1, 99);  // Fügt 99 an Index 1 ein
namen.Insert(2, "Julia");  // Fügt "Julia" an Index 2 ein
gibZahlenAus(".Insert(int index, T item)", zahlen);
gibNamenAus(".Insert(int index, T item)", namen);

// .Contains(T item)
Console.WriteLine("Contains.Contains(T item)");
Console.WriteLine("zahlen.Contains(58) = " + zahlen.Contains(58));
Console.WriteLine("namen.Contains(58) = " + namen.Contains("Marie"));


// .Count
Console.WriteLine("Anzahl der Elemente in zahlen: " + zahlen.Count);
Console.WriteLine("Anzahl der Elemente in namen: " + namen.Count);

// .Clear()
zahlen.Clear();
namen.Clear();
Console.WriteLine("Liste nach dem Leeren:");
Console.WriteLine("Anzahl der Elemente in zahlen: " + zahlen.Count);
Console.WriteLine("Anzahl der Elemente in namen: " + namen.Count);


void gibZahlenAus(string text, List<int> list)
{
    Console.WriteLine("List<int> nach " + text);
    foreach (int item in list)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

void gibNamenAus(string text, List<string> list)
{
    Console.WriteLine("List<string> nach " + text);
    foreach (string item in list)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
