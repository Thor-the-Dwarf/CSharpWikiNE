
Console.WriteLine("Array");
Console.WriteLine("Eine Art Liste");
Console.WriteLine("Eckige Klammern");
Console.WriteLine("Die Länge von Arrays ist nicht veränderbar");
Console.WriteLine("Es darf nur einen Datentyp in einem Array geben");
Console.WriteLine("Arrays sind null-basiert");
Console.WriteLine("Bezeichner am besten im Plural");

int[] values;                   // Deklaration als Array von int
int[] numbers = new int[3];     // Initialisierung

Console.WriteLine("falsche Nutzung");
Console.WriteLine(numbers);     // Gibt den Typnamen des Random-Objekts aus

Console.WriteLine("richtige Nutzung");
Console.WriteLine("Der Default-Wert des Datentyps wird automatisch eingefügt");

// 
Console.WriteLine(numbers[0]);  // 0
Console.WriteLine(numbers[1]);  // 0
Console.WriteLine(numbers[2]);  // 0

Console.WriteLine("Arry befüllen");
numbers[0] = 7;
numbers[1] = 11;
numbers[2] = 23;
    
Console.WriteLine("Einen Array ausgeben");
Console.WriteLine(string.Join(", ", numbers));  // 7, 11, 23

Console.WriteLine("Als Objekt hat er ein Attribut namens Length");
Console.WriteLine(numbers.Length);  // 3


Console.WriteLine("Array mit einer for-Schleife ausgeben");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");  // 7 11 23
}
Console.WriteLine();


Console.WriteLine("rray mit einer foreach-Schleife ausgeben");
foreach (int value in numbers)
{
    Console.Write(value + " ");  // 7 11 23
}
Console.WriteLine();


Console.WriteLine("Kurzschreibweise");
string[] namen2 = { "Peter", "Paul", "Mary" };
Console.WriteLine(string.Join(", ", namen2));  // Peter, Paul, Mary

Console.WriteLine("Arrays mit Arrays überschreiben");
int[] z1 = { 1, 2, 3 };
int[] z2 = { 7, 8, 9, 10 };
z2 = z1;
Console.WriteLine(string.Join(", ", z2));  // 1
Console.WriteLine(string.Join(", ", z2));  // 1, 2, 3, 4, 5


Console.WriteLine("andere Defaultwerte");
char[] ca = new char[7];
Console.WriteLine(string.Join(", ", ca));  // Alle Leerzeichen

bool[] ba = new bool[3];
Console.WriteLine(string.Join(", ", ba));  // False, False, False

double[] da = new double[5];
Console.WriteLine(string.Join(", ", da));  // 0.0, 0.0, 0.0, 0.0, 0.0

string[] sa = new string[8];
Console.WriteLine(string.Join(", ", sa));  // , , , , , , ,


Console.WriteLine("Array mit der Länge 0");
int[] ia = new int[0];
Console.WriteLine(string.Join(", ", ia));  // Leere Ausgabe
Console.WriteLine(ia.Length);              // 0