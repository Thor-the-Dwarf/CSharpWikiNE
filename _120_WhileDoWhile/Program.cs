Console.WriteLine("while");
// Kopfgesteuerte Schleife
int i = 0;
while (i < 10)
{
    Console.Write(i + " ");
    i++;
}

Console.WriteLine();

Console.WriteLine("do while");
// Wird mindestens einmal durchlaufen
int j = 1234567;
do
{
    Console.Write(j + " ");
    j++;
} while (j < 10);

Console.WriteLine();



Console.WriteLine("Stärke von while/do while");
// Die Anzahl der Durchläufe muss nicht bekannt sein.
Random r = new Random();
int wurf = 0;
int counter = 0;
while (wurf != 6)
{
    wurf = r.Next(6) + 1;
    Console.Write(wurf + " ");
    counter++;
}
Console.WriteLine("Anzahl der Durchläufe: " + counter);