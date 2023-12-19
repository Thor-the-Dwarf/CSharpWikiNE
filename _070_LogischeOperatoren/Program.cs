Console.WriteLine("Logische Operatoren");
Console.WriteLine("Boolsche Operatoren");
Console.WriteLine("&&, ||, ^, !");

Console.WriteLine("&& - UND (sowohl als auch)");
Console.WriteLine("Nur true, wenn beide true sind");
Console.WriteLine(true && true);     // true
Console.WriteLine(false && true);    // false
Console.WriteLine(true && false);    // false
Console.WriteLine(false && false);   // false

Console.WriteLine("|| - ODER");
Console.WriteLine("true, wenn einer der beiden true ist");
Console.WriteLine(true || true);     // true
Console.WriteLine(false || true);    // true
Console.WriteLine(true || false);    // true
Console.WriteLine(false || false);   // false

Console.WriteLine("^ - Entweder-Oder");
Console.WriteLine("Nur true, wenn einer true ist");
Console.WriteLine(true ^ true);     // false  !!! Unterschied zu ||
Console.WriteLine(false ^ true);    // true
Console.WriteLine(true ^ false);    // true
Console.WriteLine(false ^ false);   // false

Console.WriteLine("! - NICHT (not)");
Console.WriteLine(!(1 == 1));  // false
Console.WriteLine(!true);      // false
Console.WriteLine(!false);     // true