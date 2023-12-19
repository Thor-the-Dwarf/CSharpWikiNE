using System.Globalization;

Console.WriteLine("Math.Round() - Banker's Rounding");
Console.WriteLine("rundet zur nächsten Ganzzahl");
Console.WriteLine(Math.Round(4.5));   // 4
Console.WriteLine(Math.Round(4.51));    // 5
Console.WriteLine(Math.Round(-4.5));   // -4
Console.WriteLine(Math.Round(-4.51));   // -5

Console.WriteLine("Math.Floor() - Abrunden");
Console.WriteLine(Math.Floor(4.9));   // 4.0
Console.WriteLine(Math.Floor(-4.9));  // -5.0

Console.WriteLine("Math.Ceiling() - Aufrunden");
Console.WriteLine(Math.Ceiling(1.2));   // 2.0
Console.WriteLine(Math.Ceiling(-1.2));  // -1.0

Console.WriteLine("Runden durch String Formartierung");
Console.WriteLine(string.Format("{0:0.0}", 123.45));   // 123.5
Console.WriteLine(string.Format("{0:0.0}", 123.449));  // 123.4

Console.WriteLine("String Formartierung - Anzahl der Nachkommastellen");
Console.WriteLine(string.Format("{0:0.##}", 123.3456789));  // 123.34
Console.WriteLine(string.Format("{0:0.###}", 123.3456789));  // 123.34

Console.WriteLine("mit string.Format() könnte man den ganzen Tag füllen. Hier sind noch ein paar Möglichkeiten");
Console.WriteLine(string.Format("{0:N0}", 1234567890));  // 1.234.567.890
Console.WriteLine(string.Format("{0:N1}", 1234567890));  // 1.234.567.890,0

string zahlStr = string.Format(CultureInfo.GetCultureInfo("en-US"), "{0:0.00}", 10 / 3.0);
Console.WriteLine(zahlStr);  // "3.33"
