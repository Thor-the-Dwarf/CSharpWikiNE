// Zuweisungsoperatoren


// Der Rückgabewert einer Zuweisung ist der zugewiesene Wert
int x;
Console.WriteLine(x = 33);  // 23
Console.WriteLine(x);       // 23

Console.WriteLine("Folgende Operation verändert x nicht");
Console.WriteLine(x + 1);
Console.WriteLine(x);
Console.WriteLine("Folgendes aber schon");
Console.WriteLine(x = x + 1);
Console.WriteLine(x);

Console.WriteLine("Verkürzte Zuweisungsoperatoren");
Console.WriteLine("+= -= *= /= %=");

x += 7;
Console.WriteLine(x);  // 41
x -= 10;
Console.WriteLine(x); // 31
x %= 9;
Console.WriteLine(x);  // 4

// Multiple Assignment
// Kommaseparierte Liste
// Die Variablen müssen vom gleichen Datentyp sein
// Der Datentyp steht einmal am Anfang der Zeile
int y = 6, z = 30;
Console.WriteLine(y);  // 6
Console.WriteLine(z);  // 30
