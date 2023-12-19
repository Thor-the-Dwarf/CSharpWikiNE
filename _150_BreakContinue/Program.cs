
Console.WriteLine("break");
Console.WriteLine("Kann in Schleifen oder im switch auftauchen");
Console.WriteLine("Beendet die Schleife komplett");

for (int i = 1; i < 10; i++)
{
    if (i == 7)
    {
        break;
    }
    Console.Write(i + " ");  // 1 2 3 4 5 6
}
Console.WriteLine();

Console.WriteLine("continue");
Console.WriteLine("Kann nur in Schleifen auftauchen");
Console.WriteLine("Beendet den aktuellen Schleifendurchlauf vorzeitig");
Console.WriteLine("und führt die Schleife fort");

for (int i = 1; i < 10; i++)
{
    // Console.WriteLine("Hello");
    if (i == 7)
    {
        continue;
    }
    Console.Write(i + " ");  // 1 2 3 4 5 6 8 9
}