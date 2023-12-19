
Console.WriteLine("Rechenoperatoren");
Console.WriteLine(3 + 7);   // 10
Console.WriteLine("3" + "7");   // 37
Console.WriteLine(13 - 7);  // 6
Console.WriteLine(3 * 7);   // 21
Console.WriteLine(21 / 7);  // 3

Console.WriteLine("Bei zwei Integern wird ein Integer zurück gegeben (Integer-Division)");
Console.WriteLine(11 / 2);  // 5

Console.WriteLine("Wenn mindestens eine Fließkommazahl dabei ist, wird ein Double zurück gegeben");
Console.WriteLine(11.0 / 2);    // 5.5
Console.WriteLine(11 / 2.0);    // 5.5
Console.WriteLine(11.0 / 2.0);  // 5.5
Console.WriteLine((double) 11 / 2);    // 5.5
Console.WriteLine((double) (11 / 2));  // 5.0

Console.WriteLine("Modulo - Restwert-Division");
Console.WriteLine(37 % 7);  // 2
Console.WriteLine(7 % 7);   // 0
Console.WriteLine(4 % 7);   // 4 (die erste Zahl)

Console.WriteLine("Inkrement- & Dekrementoperator");
int x = 0;
Console.WriteLine(x++);  // 0
Console.WriteLine(x);  // 1
Console.WriteLine(++x);  // 2
Console.WriteLine(x--);  // 2
Console.WriteLine(x);  // 1
Console.WriteLine(--x);  // 0