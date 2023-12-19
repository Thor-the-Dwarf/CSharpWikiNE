
// Begriffe die wir verwenden:
int z1 = 23;  // Initialisierung
int z2;       // Deklaration
z2 = 7;       // Zuweisung


// Primitive Datentypen

Console.WriteLine("Byte - 8-Bit");
byte b1 = 127;
Console.WriteLine(b1);  // 127

Console.WriteLine("\nShort - 16-Bit");
short sh1 = -32768;
Console.WriteLine(sh1);                         // -32768
Console.WriteLine(Math.Pow(2, 16));             // 65536.0
Console.WriteLine(-(Math.Pow(2, 16) / 2));      // -32768.0
Console.WriteLine((Math.Pow(2, 16) / 2) - 1);   // 32767.0

Console.WriteLine("\nInteger - 32-Bit");
int int1 = 123456789;
Console.WriteLine(int1);                        // 123456789
Console.WriteLine(Math.Pow(2, 32));             // 4.294967296E9
Console.WriteLine(-(Math.Pow(2, 32) / 2));      // -2.147483648E9
Console.WriteLine((Math.Pow(2, 32) / 2) - 1);   // 2.147483647E9

Console.WriteLine("\nLong - 64-Bit");
long lo1 = 5_000_000_000L;
Console.WriteLine(lo1);  // 5000000000
Console.WriteLine(Math.Pow(2, 64));             // 1.8446744073709552E19
Console.WriteLine(-(Math.Pow(2, 64) / 2));      // -9.223372036854776E18
Console.WriteLine((Math.Pow(2, 64) / 2) - 1);   // 9.223372036854776E18

Console.WriteLine("\nFloat - 32-Bit");
float f1 = 1234.567F;
Console.WriteLine(f1);                          // 1234.567

Console.WriteLine("\nDouble - 64-Bit");
double d1 = 1234567.1234567;
Console.WriteLine(d1);                          // 1234567.1234567

Console.WriteLine("\nBoolean - 8-Bit");
bool boo1 = true;
Console.WriteLine(boo1);  // true
bool boo2 = false;
Console.WriteLine(boo2);  // false

Console.WriteLine("\nCharacter - 16-Bit");
char c1 = 'A';
Console.WriteLine(c1);  // A

Console.WriteLine("\nUnicode");
char c4 = '\u0024';
Console.WriteLine(c4);  // $

Console.WriteLine("\nZahlen mit Unterstrichen");
Console.WriteLine(1_000_000_000);  // 1000000000
Console.WriteLine(0.123_456_789);  // 0.123456789
Console.WriteLine(1___________0);  // 10

