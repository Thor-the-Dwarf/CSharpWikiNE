
Console.WriteLine("Kontrollstruktur");
Console.WriteLine("if, else if, else");
Console.WriteLine("else if kann es beliebig oft geben");
Console.WriteLine("else darf es nur einmal geben");



Console.WriteLine("if");
if (true)
{
    Console.WriteLine("Bedingung ist true");
}
int x = 7;
if (x < 8)
{
    Console.WriteLine("x ist eine Sieben");
}

Console.WriteLine("if else");
if (x == 7)
{
    Console.WriteLine("X ist Sieben!");
}
else
{
    Console.WriteLine("X ist keine sieben!");
}

Console.WriteLine("if else if");
if (x <= 5)
{
    Console.WriteLine("X ist kleiner gleich Fünf!");
}
else if (x == 7)
{
    Console.WriteLine("X ist eine Sieben!");
}


Console.WriteLine("if else if else");
if (x >= 11)  // WENN
{
    Console.WriteLine("In x ist größer gleich Elf!");
}
else if (x == 6)  // SONST WENN
{
    Console.WriteLine("X ist eine  Sechs");
}
else if (x == 8)  // SONST WENN
{
    Console.WriteLine("X ist eine  Acht");
}
else  // SONST
{
    Console.WriteLine("X ist keine Elf oder Sechs oder Acht!");
}


Console.WriteLine("Verschachteln");
if (x != 10)
{
    if (x != 1)
    {
        if (x != 20)
        {
            Console.WriteLine("X ist keine Zehn Eins oder Zwanzig!");
        }
    }
}