

Console.WriteLine("Type-Casting - Typen-Umwandlung");

Console.WriteLine("Implizietes Casting");

// Kleinerer Datentyp in größeren Container ist erlaubt
byte b1 = 100;
int int1 = b1;

// Größerer Datentyp geht nicht in einen kleineren Container
int int2 = 42;
// byte b2 = int2;  // Fehler: Der Typ "int" kann nicht implizit in "byte" konvertiert werden

Console.WriteLine("Explizites Casting");
Console.WriteLine("Datentyp in Klammern davor schreiben");
int int3 = 73;
byte b3 = (byte)int3;
Console.WriteLine(b3);  // 73

Console.WriteLine("Bei zu großen Werten gibt es einen Überlauf");
int int4 = 128;
byte b4 = (byte)int4;
Console.WriteLine(b4);           // -128
Console.WriteLine((byte)129);    // -127

// int <-> double
int int5 = 78;
double d5 = int5;    // Implizites Type-Casting
d5 = (double)int5;   // Funktioniert, ist aber nicht nötig
Console.WriteLine(d5);  // 78.0

double d6 = 12345.6789;
int int6 = (int)d6;
Console.WriteLine(int6);  // 12345

// float
float flo1 = 123;
Console.WriteLine(flo1);  // 123.0

float flo2 = 123.45f;
float flo3 = (float)123.45;

// Integer <-> String
int int7 = 12345;
string str7 = int7.ToString();
Console.WriteLine(str7);  // 12345

string str8 = "6789";
Console.WriteLine(str8 + 1);  // 67891
int int8 = int.Parse(str8);
Console.WriteLine(int8 + 1);  // 6790

// Lost in casting
int i = 1234567890;
float f = i;
Console.WriteLine(i - (int)f);          // -46
Console.WriteLine(i - (int)(float)i);  // -46
Console.WriteLine(f);  // 1.23456794E9

// All compound assignment operators internally do an explicit cast.
byte b = 1;
short s = 1;
// s = s + b;  // Fehler: Konvertierung von 'int' in 'short' kann Datenverlust verursachen
s += b;
Console.WriteLine(s);  // 2