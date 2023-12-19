public class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hallo Klasse!");
    }
}

/*
    Eine öffentliche Klasse mit Main-Methode: 
        Üblicherweise gibt es in einem C#-Projekt eine einzige öffentliche Klasse 
        mit der Main-Methode. 
        Diese Main-Methode dient als Einstiegspunkt des Programms.
*/

class NotMainClass
{
    // public static void Main(string[] args)       // Fehler
    // {
    //     // es darf nur eine MainMethode im Projekt geben
    // }
}