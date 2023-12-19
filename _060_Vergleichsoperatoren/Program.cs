
Console.WriteLine("Vergleichsoperatoren");
Console.WriteLine("== != < > <= >=");
Console.WriteLine("Ein Ausdruck mit einem Vergleichsoperator evaluiert immer zu einem Boolean.");

Console.WriteLine(3 == 4);  // false
Console.WriteLine(2 != 7);  // true

// Jeder Numerische Typ kann mit == verglichen werden
// Der Integer wird implizit zum Float gecastet:
Console.WriteLine(3 == 3.0);  // true