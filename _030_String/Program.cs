// String - Zeichenkette
// Klasse, daher Datentyp großgeschrieben
// Referenztyp
// Doppelte Anführungszeichen
// Unveränderlich - immutable

string text = "Hello World";
Console.WriteLine(text);  // Hello World

string text2 = new string("So geht es auch!");
Console.WriteLine(text2);

// String-Verkettung - Konkatenation
// Pluszeichen als Operator

string name = "Peter";
Console.WriteLine(text + name);        // Hello WorldPeter
Console.WriteLine(text + " " + name);  // Hello World Peter

// Nur ein Operand muss ein String sein
// Implizite Typenkonvertierung

Console.WriteLine(42 + 42 + text + 21 + 21);                // 84Hello World2121
Console.WriteLine(42 + 42 + "Hello World"  + 21 + 21);      // 84Hello World2121


// null
string str = null;
// Console.WriteLine(str.GetType());  // Würde eine NullReferenceException auslösen

// Konkatenation mit null
Console.WriteLine(null + "Hello");  // nullHello
Console.WriteLine(42 + "Hello");
string str2 = null;
str2 += "Peter";
Console.WriteLine(str2);  // nullPeter
